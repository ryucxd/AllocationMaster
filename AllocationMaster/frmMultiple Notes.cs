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
    public partial class frmMultiple_Notes : Form
    {
        public int _door_id { get; set; }
        public frmMultiple_Notes(int door_id)
        {
            InitializeComponent();
            _door_id = door_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check chkbox + note box
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("Please enter a note first!", "Missing Note!", MessageBoxButtons.OK);
                return;
            }
            if (chkBending.Checked == false && chkWelding.Checked == false && chkBuffing.Checked == false && chkPainting.Checked == false && chkPacking.Checked == false)
            {
                MessageBox.Show("Please select at least one department before adding this note!", "Missing department!", MessageBoxButtons.OK);
                return;
            }
            //get the note for each  dept
            string bending_note = "", welding_note = "", buffing_note = "", painting_note = "", packing_note = "";
            string new_note = " " + txtNote.Text.Replace("'", "") + " - " + CONNECT.login_full_name + " - " + DateTime.Now.ToString();
            string sql = "select bending_note,welding_note,buffing_note,painting_note,packing_note from dbo.door where id = " + _door_id.ToString();

            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bending_note = dt.Rows[0][0].ToString();
                    welding_note = dt.Rows[0][1].ToString();
                    buffing_note = dt.Rows[0][2].ToString();
                    painting_note = dt.Rows[0][3].ToString();
                    packing_note = dt.Rows[0][4].ToString();
                }

                //check each chkbox - if its ticked then + the note and commit
                if (chkBending.Checked == true)
                {
                    if (bending_note.Length > 0)
                        bending_note = bending_note + Environment.NewLine;

                    sql = "UPDATE dbo.door SET bending_note = '" + bending_note + new_note + "' WHERE id = " + _door_id.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                }
                if (chkWelding.Checked == true)
                {
                    if (welding_note.Length > 0)
                        welding_note = welding_note + Environment.NewLine;

                    sql = "UPDATE dbo.door SET welding_note = '" + welding_note + new_note + "' WHERE id = " + _door_id.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                }
                if (chkBuffing.Checked == true)
                {
                    if (buffing_note.Length > 0)
                        buffing_note = buffing_note + Environment.NewLine;

                    sql = "UPDATE dbo.door SET buffing_note = '" + buffing_note + new_note + "' WHERE id = " + _door_id.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                }
                if (chkPainting.Checked == true)
                {
                    if (painting_note.Length > 0)
                        painting_note = painting_note + Environment.NewLine;

                    sql = "UPDATE dbo.door SET painting_note = '" + painting_note + new_note + "' WHERE id = " + _door_id.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                }
                if (chkPacking.Checked == true)
                {
                    if (packing_note.Length > 0)
                        packing_note = packing_note + Environment.NewLine;

                    sql = "UPDATE dbo.door SET packing_note = '" + packing_note + new_note + "' WHERE id = " + _door_id.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            this.Close();

        }
    }
}
