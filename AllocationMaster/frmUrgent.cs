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
    public partial class frmUrgent : Form
    {
        public int _door_id { get; set; }
        public frmUrgent(int door_id)
        {
            InitializeComponent();
            _door_id = door_id;
            txtDoorID.Text = _door_id.ToString();
            loadData();
        }

        private void loadData()
        {

            string sql = "SELECT  CASE WHEN priority_status_stores = -1 then 'Urgent' else '' end as priority_status_stores,date_stores,complete_stores, " +
                "CASE WHEN priority_status = -1 then 'Urgent' else '' end as priority_status ,date_bend, complete_bend, " +
                "CASE WHEN priority_status_weld = -1 then 'Urgent' else '' end as priority_status_weld,date_weld,complete_weld, " +
                "CASE WHEN priority_status_buff = -1 then 'Urgent' else '' end as priority_status_buff,date_buff, complete_buff, " +
                "CASE WHEN priority_status_paint = -1 then 'Urgent' else '' end as priority_status_paint,date_paint,complete_paint, " +
                "CASE WHEN priority_status_pack = -1 then 'Urgent' else '' end as priority_status_pack,date_pack,complete_pack, " +
                "CASE WHEN priority_status_punch = -1 then 'Urgent' else '' end as priority_status_punch ,date_punch,complete_punch ," +
                "date_completion FROM dbo.door  WHERE id = " + _door_id.ToString();
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //use this dt to fill out all the  boxes
                    txtStoresUrgent.Text = dt.Rows[0][0].ToString();
                    txtStoresDate.Text = dt.Rows[0][1].ToString();
                    if (dt.Rows[0][2].ToString() == "-1")
                        chkStores.Checked = true;
                    else
                        chkStores.Checked = false;

                    txtPunchingUrgent.Text = dt.Rows[0][3].ToString();
                    txtPunchingDate.Text = dt.Rows[0][4].ToString();
                    if (dt.Rows[0][5].ToString() == "-1")
                        chkPunching.Checked = true;
                    else
                        chkPunching.Checked = false;

                    txtBendingUrgent.Text = dt.Rows[0][6].ToString();
                    txtBendingDate.Text = dt.Rows[0][7].ToString();
                    if (dt.Rows[0][8].ToString() == "-1")
                        chkBending.Checked = true;
                    else
                        chkBending.Checked = false;

                    txtWeldingUrgent.Text = dt.Rows[0][9].ToString();
                    txtWeldingDate.Text = dt.Rows[0][10].ToString();
                    if (dt.Rows[0][11].ToString() == "-1")
                        chkWelding.Checked = true;
                    else
                        chkWelding.Checked = false;

                    txtBuffingUrgent.Text = dt.Rows[0][12].ToString();
                    txtBuffingDate.Text = dt.Rows[0][13].ToString();
                    if (dt.Rows[0][14].ToString() == "-1")
                        chkBuffing.Checked = true;
                    else
                        chkBuffing.Checked = false;

                    txtPaintingUrgent.Text = dt.Rows[0][15].ToString();
                    txtPaintingDate.Text = dt.Rows[0][16].ToString();
                    if (dt.Rows[0][17].ToString() == "-1")
                        chkPainting.Checked = true;
                    else
                        chkPainting.Checked = false;

                    txtPackingUrgent.Text = dt.Rows[0][18].ToString();
                    txtPackingDate.Text = dt.Rows[0][19].ToString();
                    if (dt.Rows[0][20].ToString() == "-1")
                        chkPacking.Checked = true;
                    else
                        chkPacking.Checked = false;
                }
                colour();
            }
        }

        private void colour()
        {
            if (txtStoresUrgent.Text == "Urgent")
            {
                txtStoresUrgent.BackColor = Color.MediumPurple;
                txtStoresDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtStoresUrgent.BackColor = Color.Empty;
                txtStoresDate.BackColor = Color.Empty;
            }

            if (txtPunchingUrgent.Text == "Urgent")
            {
                txtPunchingUrgent.BackColor = Color.MediumPurple;
                txtPunchingDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtPunchingUrgent.BackColor = Color.Empty;
                txtPunchingDate.BackColor = Color.Empty;
            }

            if (txtBendingUrgent.Text == "Urgent")
            {
                txtBendingUrgent.BackColor = Color.MediumPurple;
                txtBendingDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtBendingUrgent.BackColor = Color.Empty;
                txtBendingDate.BackColor = Color.Empty;
            }

            if (txtWeldingUrgent.Text == "Urgent")
            {
                txtWeldingUrgent.BackColor = Color.MediumPurple;
                txtWeldingDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtWeldingUrgent.BackColor = Color.Empty;
                txtWeldingDate.BackColor = Color.Empty;
            }

            if (txtBuffingUrgent.Text == "Urgent")
            {
                txtBuffingUrgent.BackColor = Color.MediumPurple;
                txtBendingDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtBuffingUrgent.BackColor = Color.Empty;
                txtBendingDate.BackColor = Color.Empty;
            }

            if (txtPaintingUrgent.Text == "Urgent")
            {
                txtPaintingUrgent.BackColor = Color.MediumPurple;
                txtPaintingDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtPaintingUrgent.BackColor = Color.Empty;
                txtPaintingDate.BackColor = Color.Empty;
            }


            if (txtPackingUrgent.Text == "Urgent")
            {
                txtPackingUrgent.BackColor = Color.MediumPurple;
                txtPackingDate.BackColor = Color.MediumPurple;
            }
            else
            {
                txtPackingUrgent.BackColor = Color.Empty;
                txtPackingDate.BackColor = Color.Empty;
            }
        }

        private void frmUrgent_Shown(object sender, EventArgs e)
        {
            colour();
        }

        private void txtDoorID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _door_id = Convert.ToInt32(txtDoorID.Text);
                loadData();
            }
        }

        private void btnDoorRight_Click(object sender, EventArgs e)
        {
            int door_id = Convert.ToInt32(txtDoorID.Text);
            txtDoorID.Text = (door_id + 1).ToString();
            _door_id = Convert.ToInt32(txtDoorID.Text);
            loadData();

        }

        private void btnDoorLeft_Click(object sender, EventArgs e)
        {
            int door_id = Convert.ToInt32(txtDoorID.Text);
            txtDoorID.Text = (door_id - 1).ToString();
            _door_id = Convert.ToInt32(txtDoorID.Text);
            loadData();
        }

        private void update_prio(string value,string dept)
        {
            string sql = "UPDATE dbo.door SET " + dept + " = " + value + " WHERE id = " + _door_id.ToString();
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        private void btnStores_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtStoresUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status_stores");

        }

        private void btnPunching_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtPunchingUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status_punch");
        }

        private void btnBending_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtBendingUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status");
        }

        private void btnWelding_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtWeldingUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status_weld");
        }

        private void btnBuffing_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtBuffingUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status_buff");
        }

        private void btnPainting_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtPaintingUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status_paint");
        }

        private void btnPacking_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtPackingUrgent.Text == "Urgent")
                value = "NULL";
            else
                value = "-1";
            update_prio(value, "priority_status_pack");
        }
    }
}
 