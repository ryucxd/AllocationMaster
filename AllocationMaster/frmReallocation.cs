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
    public partial class frmReallocation : Form
    {
        public frmReallocation(string dept1)
        {
            InitializeComponent();


            string dept2 = "";

            if (dept1 == "Cutting" || dept1 == "Prepping" || dept1 == "Assembly" || dept1 == "SL Buff")
                dept1 = "Slimline";
            if (dept1 == "Packing")
                dept2 = "Slimline";
            else
                dept2 = dept1;

            string sql = "SELECT  [Forename] + ' ' + [Surname] AS Name FROM dbo.view_power_plan_current_placements " +
                "LEFT JOIN[user_info].dbo.[user] u ON dbo.view_power_plan_current_placements.staff_id = u.id " +
                "WHERE(dbo.view_power_plan_current_placements.department = '" + dept1 + "' Or dbo.view_power_plan_current_placements.department = '" + dept2 + "') " +
                "ORDER BY dbo.view_power_plan_current_placements.department, [Forename] +' ' + [Surname]; ";

            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbStaff.Items.Add(row[0].ToString());
                    }
                }
                conn.Close();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CONNECT.reallocation_cancelled = -1;
            this.Close();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            CONNECT.reallocation_cancelled = 0;

            if (string.IsNullOrEmpty(cmbStaff.Text))
            {
                MessageBox.Show("Please select a staff before trying to reallocate");
                return;
            }

            CONNECT.reallocation_staff_name = cmbStaff.Text;
            this.Close();
        }
    }
}
