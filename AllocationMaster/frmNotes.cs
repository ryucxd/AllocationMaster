using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AllocationMaster
{
    public partial class frmNotes : Form
    {
        public int _door_id { get; set; }
        public string  department { get; set; }
        public frmNotes(int door_id)
        {
            InitializeComponent();
            _door_id = door_id;

            string sql = "select d.id,[NAME],[door_type_description],order_number,order_ref,door_ref from dbo.door d " +
                "left join dbo.SALES_LEDGER s on s.ACCOUNT_REF = d.customer_acc_ref " +
                "left join dbo.door_type dt on dt.id = d.door_type_id where d.id = " + door_id;
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //use this dt to fill out all the  boxes
                    txtDoorID.Text = dt.Rows[0][0].ToString();
                    txtCustomer.Text = dt.Rows[0][1].ToString();
                    txtDoorType.Text = dt.Rows[0][2].ToString();
                    txtCustomerOrder.Text = dt.Rows[0][3].ToString();
                    txtOrderReference.Text = dt.Rows[0][4].ToString();
                    txtDoorReference.Text = dt.Rows[0][5].ToString();
                }
                conn.Close();
            }

                loadNotes();
        }

        private void loadNotes()
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0: //stores
                    department = "slimline_packed_note";
                    break;
                case 1: //bending
                    department = "bending_note";
                    break;
                case 2: //welding
                    department = "welding_note";
                    break;
                case 3: //buffing
                    department = "buffing_note";
                    break;
                case 4: //painting
                    department = "painting_note";
                    break;
                case 5: //packing
                    department = "packing_note";
                    break;
                case 6: //sl stores
                    department = "sl_stores_note";
                    break;
                case 7: //cutting
                    department = "cutting_note";
                    break;
                case 8: //prepping
                    department = "prepping_note";
                    break;
                case 9: //assembly
                    department = "assembly_note";
                    break;
                case 10: //sl buff
                    department = "sl_buff_note";
                    break;
            }
            //load the note now 
            string sql = "SELECT " + department + " FROM dbo.door where id = " + _door_id.ToString();
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    txtNote.Text = (string)cmd.ExecuteScalar().ToString();
                }
                    conn.Close();
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNotes();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            //open a form for the user to enter
            frmAppendNote frm = new frmAppendNote(department,_door_id);
            frm.ShowDialog();
            loadNotes();
        }

        private void btnMultipleNotes_Click(object sender, EventArgs e)
        {
            frmMultiple_Notes frm = new frmMultiple_Notes(_door_id);
            frm.ShowDialog();
            loadNotes();
        }
    }
}
