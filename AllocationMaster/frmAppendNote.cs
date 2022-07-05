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
    public partial class frmAppendNote : Form
    {
        public string _department { get; set; }
        public int _door_id { get; set; }
        public frmAppendNote(string department,int door_id)
        {
            InitializeComponent();
            _department = department;
            _door_id = door_id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT " + _department + " FROM dbo.door WHERE id = " + _door_id;
            string note = "";
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                    note = (string)cmd.ExecuteScalar().ToString();

                txtNote.Text = txtNote.Text.Replace("'", "");
                note = note + Environment.NewLine + txtNote.Text + " - " + CONNECT.login_full_name + " - " + DateTime.Now.ToString();

                sql = "UPDATE dbo.door SET " + _department + " = '" + note + "' WHERE id = " + _door_id;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                    cmd.ExecuteNonQuery();

                    conn.Close();
            }

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
