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
    public partial class frmLaserParts : Form
    {
        public frmLaserParts(int door_id)
        {
            InitializeComponent();

            lblTitle.Text = door_id.ToString() + " - Laser Parts";

            string sql = "SELECT part_description as [Description],item_quantity as [Quantity],CASE WHEN part_complete = 0 THEN CAST(0 AS BIT) WHEN part_complete IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS Complete FROM dbo.door_program_laser_parts d left join dbo.laser_parts l on d.part_id = l.id where d.door_id = " + door_id.ToString();
            
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.ReadOnly = true;
                }
                    conn.Close();
            }
        }
    }
}
