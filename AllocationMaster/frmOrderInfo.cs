using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AllocationMaster
{
    public partial class frmOrderInfo : Form
    {
        public frmOrderInfo(string department, int door_id)
        {
            InitializeComponent();

            lblDept.Text = department + " Note:";
            switch (department)
            {
                case "Bending":
                    department = "bending_note";
                    break;
                case "Welding":
                    department = "welding_note";
                    break;
                case "Dressing":
                    department = "buffing_note";
                    break;
                case "Painting":
                    department = "painting_note";
                    break;
                case "Packing":
                    department = "packing_note";
                    break;
                case "Cutting":
                    department = "cutting_note";
                    break;
                case "Prepping":
                    department = "prepping_note";
                    break;
                case "Assembly":
                    department = "assembly_note";
                    break;
                case "SL Buff":
                    department = "sl_buff_note";
                    break;
            }

            string sql = "select id,order_id,order_number,order_ref,quantity_on_order,quantity_same,cast(date_order as date),quote_number,install_quote_ref,door_ref,special_description,up_complete_date,date_paint_complete," +
                "dateadd(N, 60, date_paint_complete) as painting_auto_allocation," + department + " from dbo.door where id = " + door_id;

            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //use this dt to fill out all the  boxes
                    txtDoorNumber.Text = dt.Rows[0][0].ToString();
                    txtOrder.Text = dt.Rows[0][1].ToString();
                    txtOrderNumber.Text = dt.Rows[0][2].ToString();
                    txtOrderReference.Text = dt.Rows[0][3].ToString();
                    txtQtyOrder.Text = dt.Rows[0][4].ToString();
                    txtQtySame.Text = dt.Rows[0][5].ToString();
                    txtOrderDate.Text = Convert.ToDateTime(dt.Rows[0][6].ToString()).ToString("dd/MM/yyyy");
                    txtQuoteNumber.Text = dt.Rows[0][7].ToString();
                    txtInstallNumber.Text = dt.Rows[0][8].ToString();
                    txtDoorRef.Text = dt.Rows[0][9].ToString();
                    txtSpecialDescription.Text = dt.Rows[0][10].ToString();
                    txtTimeUp.Text = dt.Rows[0][11].ToString();
                    txtTimePaintingComplete.Text = dt.Rows[0][12].ToString();
                    txtPaintingAutoAllocationAt.Text = dt.Rows[0][13].ToString();
                    txtDeptNote.Text = dt.Rows[0][14].ToString();
                }
                sql = "SELECT dbo.paint_to_door.[description] as [Colour],dbo.paint_finish.finish as [Finish],  supplier.[NAME] as [Supplier], round(dbo.paint_to_door.powder_kgs ,2) as Kgs, " +
                    "CASE WHEN dbo.paint_to_door.wet = 0 THEN CAST(0 AS BIT) WHEN dbo.paint_to_door.wet IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS Wet, " +
                    "CASE WHEN dbo.paint_to_door.unallocated = 0 THEN CAST(0 AS BIT) WHEN dbo.paint_to_door.unallocated IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS UA, " +
                    "dbo.paint_to_door.frame_leaf as [F/L] FROM dbo.door INNER JOIN dbo.paint_to_door ON dbo.door.id = dbo.paint_to_door.door_id " +
                    "LEFT JOIN dbo.supplier ON dbo.paint_to_door.supplier_id = dbo.supplier.id INNER JOIN dbo.paint_finish ON dbo.paint_to_door.finish_id = dbo.paint_finish.id where dbo.door.id = " + door_id;
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPainting.DataSource = dt;
                }
                //foreach (DataGridViewColumn col in dgvPainting.Columns)
                //    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPainting.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPainting.Columns[1].Width = 55;
                dgvPainting.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPainting.Columns[3].Width = 30;
                dgvPainting.Columns[4].Width = 30;
                dgvPainting.Columns[5].Width = 30;
                dgvPainting.Columns[6].Width = 30;

            }
            dgvPainting.ClearSelection();
        }

        private void frmOrderInfo_Shown(object sender, EventArgs e)
        {
            dgvPainting.ClearSelection();
        }
    }
}
