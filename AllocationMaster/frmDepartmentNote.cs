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
    public partial class frmDepartmentNote : Form
    {
        public string _department_note { get; set; }
        public int _door_id { get; set; }
        public frmDepartmentNote(string department,string department_note,int door_id)
        {
            InitializeComponent();
            _department_note = department_note;
            _door_id = door_id;
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT " + department_note + " FROM dbo.door WHERE id = " + door_id.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                    txtNote.Text = (string)cmd.ExecuteScalar().ToString();
                
                    conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAppendNote frm = new frmAppendNote(_department_note, _door_id);
            frm.ShowDialog();
            this.Close();
        }
    }
}
