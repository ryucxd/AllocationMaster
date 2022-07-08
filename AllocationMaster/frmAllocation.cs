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
    public partial class frmAllocation : Form
    {
        public string department { get; set; }
        public int complete_stores_index { get; set; }
        public int prev_op_index { get; set; }
        public int needs_paint_index { get; set; }
        public int up_index { get; set; }
        public int door_id_index { get; set; }
        public int urgent_box_index { get; set; }
        public int urgent_button_index { get; set; }
        public int door_type_index { get; set; }
        public int order_info_index { get; set; }
        public int infl_index { get; set; }
        public int finish_index { get; set; }
        public int customer_index { get; set; }
        public int value_index { get; set; }
        public int bend_alloc_paint_loc_index { get; set; }
        public int time_index { get; set; }
        public int time_remaining_index { get; set; }
        public int staff_allocation_index { get; set; }
        public int program_date_index { get; set; }
        public int batch_date_index { get; set; }
        public int cutting_index { get; set; }
        public int prep_laser_index { get; set; }
        public int assembly_punch_index { get; set; }
        public int sl_buff_bend_index { get; set; }
        public int weld_index { get; set; }

        public int buff_index { get; set; }
        public int paint_index { get; set; }
        public int pack_index { get; set; }
        public int comp_date_index { get; set; }
        public int install_index { get; set; }
        public int install_by_index { get; set; }
        public int op1_index { get; set; }
        public int op2_index { get; set; }
        public int op3_index { get; set; }
        public int op4_index { get; set; }
        public int d_op1_index { get; set; }
        public int d_op2_index { get; set; }
        public int d_op3_index { get; set; }
        public int d_op4_index { get; set; }
        public int sw_index { get; set; }
        public int sb_index { get; set; }

        public int complete_weld_index { get; set; }
        public int complete_buff_index { get; set; }
        public int complete_paint_index { get; set; }
        public int complete_pack_index { get; set; }
        public int priority_weld_index { get; set; }
        public int priority_buff_index { get; set; }
        public int priority_paint_index { get; set; }
        public int priority_pack_index { get; set; }
        public int department_note { get; set; }
        public int proving_weld_index { get; set; }
        public int date_paint_complete_index { get; set; }
        public int management_priority_index { get; set; }

        public int date_complete_order_by_index { get; set; }
        public int _slimline { get; set; }
        //current alocation indexes

        public int current_id_index { get; set; }
        public int current_door_id_index { get; set; }
        public int current_customer_index { get; set; }
        public int current_total_time_index { get; set; }
        public int current_time_remaining_index { get; set; }
        public int current_start_time_index { get; set; }
        public int current_finish_time_index { get; set; }
        public int current_priority_status_index { get; set; }
        public int current_dept_note_index { get; set; }

        public int current_remove_button { get; set; }

        public frmAllocation()
        {
            InitializeComponent();

        }

        private void loadStaff(string dept1)
        {
            string dept2 = "";

            if (dept1 == "Cutting" || dept1 == "Prepping" || dept1 == "Assembly" || dept1 == "SL Buff")
                dept1 = "Slimline";
            if (dept1 == "Packing")
                dept2 = "Slimline";
            else
                dept2 = dept1;

            string sql = "SELECT dbo.view_power_plan_current_placements.department, u.id, u.user_allocated_selected_id, [Forename] + ' ' + [Surname] AS Name, " +
                "dbo.view_power_plan_current_placements.time_remaining as [Staff Member] FROM dbo.view_power_plan_current_placements " +
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
                    dgvStaff.DataSource = dt;
                }
                conn.Close();
            }

            foreach (DataGridViewColumn col in dgvStaff.Columns)
            {
                col.Visible = false;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvStaff.Columns[dgvStaff.Columns.Count - 1].Visible = true;
            dgvStaff.Columns[dgvStaff.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void column_index()
        {
            //the general columns
            complete_stores_index = dgvAllocation.Columns["Complete Stores"].Index;
            prev_op_index = dgvAllocation.Columns["Prev Op Complete"].Index;
            needs_paint_index = dgvAllocation.Columns["Needs Paint"].Index;
            up_index = dgvAllocation.Columns["UP"].Index;
            door_id_index = dgvAllocation.Columns["Door ID"].Index;
            urgent_box_index = dgvAllocation.Columns["urgent box"].Index;

            if (dgvAllocation.Columns.Contains("Urgent") == true)
                urgent_button_index = dgvAllocation.Columns["Urgent"].Index;

            door_type_index = dgvAllocation.Columns["Door Type"].Index;
            order_info_index = dgvAllocation.Columns["Order Info"].Index;
            infl_index = dgvAllocation.Columns["Infill"].Index;
            finish_index = dgvAllocation.Columns["Finish"].Index;
            customer_index = dgvAllocation.Columns["Customer"].Index;
            value_index = dgvAllocation.Columns["Value"].Index;
            bend_alloc_paint_loc_index = dgvAllocation.Columns["bend_alloc_Paint_Loc"].Index;
            time_index = dgvAllocation.Columns["Time"].Index;
            time_remaining_index = dgvAllocation.Columns["Time Remaining"].Index;
            staff_allocation_index = dgvAllocation.Columns["Staff Allocation"].Index;
            program_date_index = dgvAllocation.Columns["Program Date"].Index;
            batch_date_index = dgvAllocation.Columns["Batch Date"].Index;
            cutting_index = dgvAllocation.Columns["Cutting"].Index;
            prep_laser_index = dgvAllocation.Columns["prep_laser"].Index;
            assembly_punch_index = dgvAllocation.Columns["assembly_punch"].Index;
            sl_buff_bend_index = dgvAllocation.Columns["sl_buff_bend"].Index;
            weld_index = dgvAllocation.Columns["Weld"].Index;
            buff_index = dgvAllocation.Columns["Buff"].Index;
            paint_index = dgvAllocation.Columns["Paint"].Index;
            pack_index = dgvAllocation.Columns["Pack"].Index;
            comp_date_index = dgvAllocation.Columns["Comp Date"].Index;
            install_index = dgvAllocation.Columns["Install"].Index;
            install_by_index = dgvAllocation.Columns["Install By"].Index;
            date_complete_order_by_index = dgvAllocation.Columns["date_comp_order_by"].Index;

            op1_index = dgvAllocation.Columns["op1"].Index;
            op2_index = dgvAllocation.Columns["op2"].Index;
            op3_index = dgvAllocation.Columns["op3"].Index;
            op4_index = dgvAllocation.Columns["op4"].Index;
            d_op1_index = dgvAllocation.Columns["d_op1"].Index;
            d_op2_index = dgvAllocation.Columns["d_op2"].Index;
            d_op3_index = dgvAllocation.Columns["d_op3"].Index;
            d_op4_index = dgvAllocation.Columns["d_op4"].Index;

            complete_weld_index = dgvAllocation.Columns["complete_weld"].Index;
            complete_buff_index = dgvAllocation.Columns["complete_buff"].Index;
            complete_paint_index = dgvAllocation.Columns["complete_paint"].Index;
            complete_pack_index = dgvAllocation.Columns["complete_pack"].Index;

            sw_index = dgvAllocation.Columns["sw"].Index;
            sb_index = dgvAllocation.Columns["sb"].Index;

            priority_weld_index = dgvAllocation.Columns["priority_status_weld"].Index;
            priority_buff_index = dgvAllocation.Columns["priority_status_buff"].Index;
            priority_paint_index = dgvAllocation.Columns["priority_status_paint"].Index;
            priority_pack_index = dgvAllocation.Columns["priority_status_pack"].Index;

            department_note = dgvAllocation.Columns["dept_note"].Index;

            proving_weld_index = dgvAllocation.Columns["proving_welding"].Index;
            date_paint_complete_index = dgvAllocation.Columns["date_paint_complete"].Index;

            management_priority_index = dgvAllocation.Columns["management_priority"].Index;
        }

        private void formatAllocation()
        {
            column_index();
            //get the index of each column and stuff 
            for (int i = 0; i < dgvAllocation.Columns.Count; i++)
                dgvAllocation.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvAllocation.Columns[complete_stores_index].Width = 20;
            dgvAllocation.Columns[finish_index].Width = 80;


            //important rows
            dgvAllocation.Columns[door_type_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAllocation.Columns[customer_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAllocation.Columns[value_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAllocation.Columns[infl_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAllocation.Columns[staff_allocation_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //colmn names 
            dgvAllocation.Columns[complete_stores_index].HeaderText = "";
            if (_slimline == -1)
            {
                dgvAllocation.Columns[prep_laser_index].HeaderText = "Prep";
                dgvAllocation.Columns[assembly_punch_index].HeaderText = "Assembly";
                dgvAllocation.Columns[sl_buff_bend_index].HeaderText = "SL Buff";
            }
            else
            {
                dgvAllocation.Columns[prep_laser_index].HeaderText = "Laser";
                dgvAllocation.Columns[assembly_punch_index].HeaderText = "Punch";
                dgvAllocation.Columns[sl_buff_bend_index].HeaderText = "Bend";
            }
            if (department == "Welding")
                dgvAllocation.Columns[bend_alloc_paint_loc_index].HeaderText = "Bend Alloc";
            else
                dgvAllocation.Columns[bend_alloc_paint_loc_index].HeaderText = "Paint Loc";

            //hide rows
            dgvAllocation.Columns[date_complete_order_by_index].Visible = false;
            dgvAllocation.Columns[urgent_box_index].Visible = false;
            //hide all the op stuff
            dgvAllocation.Columns[op1_index].Visible = false;
            dgvAllocation.Columns[op2_index].Visible = false;
            dgvAllocation.Columns[op3_index].Visible = false;
            dgvAllocation.Columns[op4_index].Visible = false;
            dgvAllocation.Columns[d_op1_index].Visible = false;
            dgvAllocation.Columns[d_op2_index].Visible = false;
            dgvAllocation.Columns[d_op3_index].Visible = false;
            dgvAllocation.Columns[d_op4_index].Visible = false;
            //hide comp 
            dgvAllocation.Columns[complete_weld_index].Visible = false;
            dgvAllocation.Columns[complete_buff_index].Visible = false;
            dgvAllocation.Columns[complete_paint_index].Visible = false;
            dgvAllocation.Columns[complete_pack_index].Visible = false;
            //hide sw/sb
            dgvAllocation.Columns[sw_index].Visible = false;
            dgvAllocation.Columns[sb_index].Visible = false;
            //hide prio
            dgvAllocation.Columns[priority_weld_index].Visible = false;
            dgvAllocation.Columns[priority_buff_index].Visible = false;
            dgvAllocation.Columns[priority_paint_index].Visible = false;
            dgvAllocation.Columns[priority_pack_index].Visible = false;
            //last few
            dgvAllocation.Columns[department_note].Visible = false;
            dgvAllocation.Columns[proving_weld_index].Visible = false;
            dgvAllocation.Columns[date_paint_complete_index].Visible = false;
            dgvAllocation.Columns[management_priority_index].Visible = false;


            foreach (DataGridViewColumn col in dgvAllocation.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            //colouring  -- start up to staf alloc
            foreach (DataGridViewRow row in dgvAllocation.Rows)
            {
                if (string.IsNullOrEmpty(row.Cells[staff_allocation_index].Value.ToString()) == false && row.Cells[staff_allocation_index].Value.ToString() != "S")
                {
                    row.Cells[prev_op_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[needs_paint_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[up_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[door_id_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[door_type_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[order_info_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[infl_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[finish_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[customer_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[value_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[bend_alloc_paint_loc_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[time_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[time_remaining_index].Style.BackColor = Color.YellowGreen;
                }
                //allocation block
                if (row.Cells[staff_allocation_index].Value.ToString() == "Allocation Block ")
                {
                    row.Cells[prev_op_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[needs_paint_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[up_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[door_id_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[door_type_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[order_info_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[infl_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[finish_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[customer_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[value_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[bend_alloc_paint_loc_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[time_index].Style.BackColor = Color.PaleVioletRed;
                    row.Cells[time_remaining_index].Style.BackColor = Color.PaleVioletRed;
                }

                if (row.Cells[program_date_index].Value.ToString().Length > 1)
                    row.Cells[program_date_index].Style.BackColor = Color.YellowGreen;
                if (row.Cells[batch_date_index].Value.ToString().Length > 1)
                    row.Cells[batch_date_index].Style.BackColor = Color.YellowGreen;
                //op stuff
                if (1 == 1)
                {
                    //op date stuff

                    if (string.IsNullOrEmpty(row.Cells[d_op1_index].Value.ToString()) == false)
                    {
                        if (Convert.ToDateTime(row.Cells[d_op1_index].Value.ToString()) < DateTime.Now)
                            row.Cells[cutting_index].Style.BackColor = Color.PaleVioletRed;
                    }
                    if (string.IsNullOrEmpty(row.Cells[d_op2_index].Value.ToString()) == false)
                    {
                        if (Convert.ToDateTime(row.Cells[d_op2_index].Value.ToString()) < DateTime.Now)
                            row.Cells[prep_laser_index].Style.BackColor = Color.PaleVioletRed;
                    }
                    //different past 2
                    if (string.IsNullOrEmpty(row.Cells[d_op3_index].Value.ToString()) == false)
                    {
                        if (Convert.ToDateTime(row.Cells[d_op3_index].Value.ToString()) < DateTime.Now && row.Cells[op3_index].Value.ToString() == "false")
                            row.Cells[assembly_punch_index].Style.BackColor = Color.PaleVioletRed;
                    }
                    if (string.IsNullOrEmpty(row.Cells[d_op4_index].Value.ToString()) == false)
                    {
                        if (Convert.ToDateTime(row.Cells[d_op4_index].Value.ToString()) < DateTime.Now && row.Cells[op4_index].Value.ToString() == "false")
                            row.Cells[sl_buff_bend_index].Style.BackColor = Color.PaleVioletRed;
                    }

                    if (row.Cells[op1_index].Value.ToString() == "True")
                        row.Cells[cutting_index].Style.BackColor = Color.YellowGreen;
                    if (row.Cells[op2_index].Value.ToString() == "True")
                        row.Cells[prep_laser_index].Style.BackColor = Color.YellowGreen;
                    if (row.Cells[op3_index].Value.ToString() == "True")
                        row.Cells[assembly_punch_index].Style.BackColor = Color.YellowGreen;
                    if (row.Cells[op4_index].Value.ToString() == "True")
                        row.Cells[sl_buff_bend_index].Style.BackColor = Color.YellowGreen;


                }



                //priority status
                if (row.Cells[priority_weld_index].Value.ToString() == "-1")
                    row.Cells[weld_index].Style.BackColor = Color.MediumPurple;
                if (row.Cells[priority_buff_index].Value.ToString() == "-1")
                    row.Cells[buff_index].Style.BackColor = Color.MediumPurple;
                if (row.Cells[priority_paint_index].Value.ToString() == "-1")
                    row.Cells[paint_index].Style.BackColor = Color.MediumPurple;
                if (row.Cells[priority_pack_index].Value.ToString() == "-1")
                    row.Cells[pack_index].Style.BackColor = Color.MediumPurple;

                //started weld
                if (row.Cells[sw_index].Value.ToString() == "1")
                    row.Cells[weld_index].Style.BackColor = Color.LightSkyBlue;
                //started buff
                if (row.Cells[sb_index].Value.ToString() == "1")
                    row.Cells[buff_index].Style.BackColor = Color.LightSkyBlue;

                //weld buff paint pack
                if (row.Cells[complete_weld_index].Value.ToString() == "True")
                    row.Cells[weld_index].Style.BackColor = Color.YellowGreen;

                if (row.Cells[complete_buff_index].Value.ToString() == "True")
                    row.Cells[buff_index].Style.BackColor = Color.YellowGreen;

                if (row.Cells[complete_paint_index].Value.ToString() == "True")
                    row.Cells[paint_index].Style.BackColor = Color.YellowGreen;

                if (row.Cells[complete_pack_index].Value.ToString() == "True")
                {
                    row.Cells[pack_index].Style.BackColor = Color.YellowGreen;
                    //comp / install / install by -> these are all affected by comp date and have no other rules
                    row.Cells[comp_date_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[install_by_index].Style.BackColor = Color.YellowGreen;
                    row.Cells[install_index].Style.BackColor = Color.YellowGreen;
                }
                //staff allocation
                if (string.IsNullOrEmpty(row.Cells[staff_allocation_index].Value.ToString()) == false) //staff allocation is not null + textdept is null
                    row.Cells[staff_allocation_index].Style.BackColor = Color.YellowGreen;


                if (row.Cells[department_note].Value.ToString().Length > 0)
                    row.Cells[staff_allocation_index].Style.BackColor = Color.Gold;

                if (row.Cells[date_paint_complete_index].Value.ToString().Length > 0)
                {
                    if (DateTime.Now < Convert.ToDateTime(row.Cells[date_paint_complete_index].Value.ToString()).AddHours(1))
                        row.Cells[door_id_index].Style.BackColor = Color.LightSkyBlue;
                }
                if (row.Cells[proving_weld_index].Value.ToString() == "-1")
                    row.Cells[door_id_index].Style.BackColor = Color.Violet;


                //management prio  - if its green then we skip
                if (row.Cells[management_priority_index].Value.ToString() == "-1")
                {
                    if (row.Cells[assembly_punch_index].Style.BackColor != Color.YellowGreen)
                        row.Cells[assembly_punch_index].Style.BackColor = Color.Violet;

                    if (row.Cells[sl_buff_bend_index].Style.BackColor != Color.YellowGreen)
                        row.Cells[sl_buff_bend_index].Style.BackColor = Color.Violet;
                    //weld or buff includes blue
                    if (row.Cells[weld_index].Style.BackColor == Color.YellowGreen || row.Cells[weld_index].Style.BackColor == Color.LightSkyBlue)
                    { }
                    else
                        row.Cells[weld_index].Style.BackColor = Color.Violet;

                    if (row.Cells[buff_index].Style.BackColor == Color.YellowGreen || row.Cells[buff_index].Style.BackColor == Color.LightSkyBlue)
                    { }
                    else
                        row.Cells[buff_index].Style.BackColor = Color.Violet;

                    if (row.Cells[paint_index].Style.BackColor != Color.YellowGreen)
                        row.Cells[paint_index].Style.BackColor = Color.Violet;
                    if (row.Cells[pack_index].Style.BackColor != Color.YellowGreen)
                        row.Cells[pack_index].Style.BackColor = Color.Violet;
                }





            }
        }
        private void loadAllocation()
        {
            string sql = "";
            resetButtons(department);
            switch (department)
            {
                case "Bending":
                    sql = " SELECT * from view_allocation_master_bending  ";
                    break;
                case "Welding":
                    sql = " SELECT * from view_allocation_master_welding  ";
                    break;
                case "Dressing":
                    sql = " SELECT * from view_allocation_master_dressing   ";
                    break;
                case "Painting":
                    sql = " SELECT * from view_allocation_master_painting   ";
                    break;
                case "Packing":
                    sql = " SELECT * from view_allocation_master_packing   ";
                    break;
                case "Cutting":
                    sql = " SELECT * from view_allocation_master_cutting   ";
                    break;
                case "Prepping":
                    sql = " SELECT * from view_allocation_master_prepping     ";
                    break;
                case "Assembly":
                    sql = " SELECT * from view_allocation_master_assembly   ";
                    break;
                case "SL Buff":
                    sql = " SELECT * from view_allocation_master_sl_buff   ";
                    break;
            }

            if (string.IsNullOrEmpty(txtDoorID.Text) == false)
                sql = sql + " WHERE [Door ID] = " + txtDoorID.Text;


            sql = sql + " ORDER BY date_comp_order_by,[Door ID]";

            if (dgvCurrentAllocations.DataSource != null)
            {
                dgvCurrentAllocations.Columns.Clear();
                dgvCurrentAllocations.DataSource = null;
                if (dgvCurrentAllocations.Columns.Contains("X") == true)
                    dgvCurrentAllocations.Columns.Remove("X");
            }
            //string sql = "";
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {

                conn.Open();
                //using (var command = new SqlCommand("usp_allocation_form_sql_master", conn)
                //{
                //    CommandType = System.Data.CommandType.StoredProcedure
                //})
                //{
                //    command.Parameters.Add("@department", SqlDbType.VarChar).Value = dept;
                //    command.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Today;
                //    command.Parameters.Add("@door", SqlDbType.Int).Value = 0;
                //    command.Parameters.Add("@customer", SqlDbType.VarChar).Value = "";
                //    command.Parameters.Add("@slimline", SqlDbType.Int).Value = slimline ;
                //    sql = command.ExecuteScalar().ToString();
                //}

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dgvAllocation.DataSource != null)
                    {
                        try
                        {
                            dgvAllocation.Columns.Clear();
                        }
                        catch
                        { }
                        dgvAllocation.DataSource = null;
                        if (dgvAllocation.Columns.Contains("Urgent") == true)
                            dgvAllocation.Columns.Remove("Urgent");
                    }
                    dgvAllocation.DataSource = dt;

                }
                conn.Close();
            }
            column_index();
            add_buttons();
            column_index();
            formatAllocation();
        }
        private void add_buttons()
        {
            // urgent should be the only button we need 
            int columnIndex = 0;
            columnIndex = urgent_box_index + 1;
            DataGridViewButtonColumn urgentButton = new DataGridViewButtonColumn();
            urgentButton.Name = "Urgent";
            urgentButton.Text = "Urgent";
            urgentButton.UseColumnTextForButtonValue = true;
            if (dgvAllocation.Columns["Urgent_column"] == null)
                dgvAllocation.Columns.Insert(columnIndex, urgentButton);
            //
        }

        private void resetButtons(string dept)
        {
            if (dept == "Bending")
                chkBending.Checked = true;
            else
                chkBending.Checked = false;

            if (dept == "Welding")
                chkWelding.Checked = true;
            else
                chkWelding.Checked = false;

            if (dept == "Dressing")
                chkDressing.Checked = true;
            else
                chkDressing.Checked = false;

            if (dept == "Painting")
                chkPainting.Checked = true;
            else
                chkPainting.Checked = false;

            if (dept == "Packing")
                chkPacking.Checked = true;
            else
                chkPacking.Checked = false;

            if (dept == "Cutting")
                chkCutting.Checked = true;
            else
                chkCutting.Checked = false;

            if (dept == "Prepping")
                chkPrepping.Checked = true;
            else
                chkPrepping.Checked = false;

            if (dept == "Assembly")
                chkAssembly.Checked = true;
            else
                chkAssembly.Checked = false;

            if (dept == "SL Buff")
                chkSLBuff.Checked = true;
            else
                chkSLBuff.Checked = false;
        }

        private void chkBending_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBending.Checked == true)
            {
                department = "Bending";
                if (chkBending.Checked == true)
                    resetButtons(department);
                loadStaff(department);

                //custom allocation string for bending 

                string sql = "SELECT * from view_allocation_master_bending ORDER BY date_comp_order_by,[Door ID]";

                _slimline = 0;
                loadAllocation();
            }
        }
        private void chkWelding_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWelding.Checked == true)
            {
                department = "Welding";
                if (chkWelding.Checked == true)
                    resetButtons(department);
                loadStaff(department);

                string sql = "SELECT * from view_allocation_master_welding ORDER BY  date_comp_order_by,[Door ID]";

                _slimline = 0;
                loadAllocation();
            }
        }

        private void chkDressing_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDressing.Checked == true)
            {
                department = "Dressing";
                if (chkDressing.Checked == true)
                    resetButtons(department);
                loadStaff(department);

                string sql = "SELECT * from view_allocation_master_dressing ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = 0;
                loadAllocation();
            }
        }

        private void chkPainting_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPainting.Checked == true)
            {
                department = "Painting";
                if (chkPainting.Checked == true)
                    resetButtons(department);
                loadStaff(department);



                string sql = "SELECT * from view_allocation_master_painting ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = 0;
                loadAllocation();
            }

        }

        private void chkPacking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPacking.Checked == true)
            {
                department = "Packing";
                if (chkPacking.Checked == true)
                    resetButtons(department);
                loadStaff(department);
                //loadAllocation("Packing", 0);

                string sql = "SELECT * from view_allocation_master_packing ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = 0;
                loadAllocation();
            }
        }

        private void chkCutting_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCutting.Checked == true)
            {
                department = "Cutting";
                if (chkCutting.Checked == true)
                    resetButtons(department);
                loadStaff(department);

                string sql = "SELECT * from view_allocation_master_cutting ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = -1;
                loadAllocation();
            }
        }

        private void chkPrepping_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrepping.Checked == true)
            {

                department = "Prepping";
                if (chkPrepping.Checked == true)
                    resetButtons(department);
                loadStaff(department);
                string sql = "SELECT * from view_allocation_master_prepping ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = -1;
                loadAllocation();
            }
        }

        private void chkAssembly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAssembly.Checked == true)
            {
                department = "Assembly";
                if (chkAssembly.Checked == true)
                    resetButtons(department);
                loadStaff(department);

                string sql = "SELECT * from view_allocation_master_Assembly ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = -1;
                loadAllocation();
            }
        }

        private void chkSLBuff_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSLBuff.Checked == true)
            {
                department = "SL Buff";
                if (chkSLBuff.Checked == true)
                    resetButtons(department);
                loadStaff(department);

                string sql = "SELECT * from view_allocation_master_sl_buff ORDER BY  date_comp_order_by,[Door ID]";


                _slimline = -1;
                loadAllocation();
            }

        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            foreach (DataGridViewRow row in dgvStaff.Rows)
                row.DefaultCellStyle.BackColor = Color.Empty;

            dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvStaff.ClearSelection();
            loadCurrentAllocations();
        }
        private void loadCurrentAllocations()
        {
            if (dgvCurrentAllocations.DataSource != null)
            {
                dgvCurrentAllocations.Columns.Clear();
                dgvCurrentAllocations.DataSource = null;
                if (dgvCurrentAllocations.Columns.Contains("X") == true)
                    dgvCurrentAllocations.Columns.Remove("X");
            }


            //get the staff member  id 1
            int staff_id = 0;
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightSkyBlue)
                    staff_id = Convert.ToInt32(row.Cells[1].Value);
            }

            string sql = "";
            //unique string per dept
            //if (department == "Bending")
            //{
            //    sql = "SELECT dbo.door.id,s.[NAME] as [customer],round((time_bend * quantity_same) / 60, 2) as [total_time], " +
            //             "case when complete_bend = -1 then 0 else round((time_remaining_bend * quantity_same), 2) end as time_remaining ," +
            //             " started_bend,date_bend_complete,priority_status,started_bend,dbo.door.bending_note FROM dbo.door_allocation " +
            //             "LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
            //             "WHERE   dbo.door_allocation.staff_id = " + staff_id + " AND dbo.door_allocation.department = 'bending' AND complete_bend = 0 and dbo.door.id > 100000";
            //}

            if (department == "Welding")
            {
                sql = "SELECT dbo.door_allocation.id,dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(cast((time_weld * quantity_same) as float) / 60,2) as [Total Time]," +
                    "case when complete_weld = -1 then 0 else round(cast((time_remaining_weld * quantity_same) as float) / 60, 2) end as [Time Remaining] ," +
                    "started_weld as [Start Time],date_weld_complete as [Finish Time],priority_status_weld as [priority_status],dbo.door.welding_note as [Department Note]" +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id =  " + staff_id + " AND dbo.door_allocation.department = 'Welding' AND complete_weld = 0 and dbo.door.id > 100000";

            }

            if (department == "Dressing")
            {
                sql = "SELECT dbo.door_allocation.id,dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(CAST((time_buff * quantity_same) as float) / 60,2) as [Total Time]," +
                    "case when complete_buff = -1 then 0 else round(cast((time_remaining_buff * quantity_same) as float) / 60, 2) end as [Time Remaining] ," +
                    "started_buff as [Start Time],date_buff_complete as [Finish Time],priority_status_buff as [priority_status],dbo.door.buffing_note[Department Note] " +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id = " + staff_id + " AND dbo.door_allocation.department = 'dressing' AND complete_buff = 0 and dbo.door.id > 100000";
            }

            //we're gonna skip painting

            if (department == "Packing")
            {
                sql = "SELECT dbo.door_allocation.id, dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(CAST((time_pack * quantity_same) as float) / 60,2) as [Total Time], " +
                    "case when complete_pack = -1 then 0 else round(CAST((time_remaining_pack * quantity_same) as float) / 60, 2) end as [Time Remaining] , " +
                    "started_pack as [Start Time],date_pack_complete as [Finish Time],priority_status_pack as [priority_status],dbo.door.packing_note[Department Note] " +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id = " + staff_id + " AND dbo.door_allocation.department = 'packing' AND complete_pack = 0 and dbo.door.id > 100000";
            }

            if (department == "Cutting")
            {
                sql = "SELECT dbo.door_allocation.id,dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(cast((time_cutting * quantity_same) as float) / 60,2) as [Total Time], " +
                    "case when complete_cutting = -1 then 0 else round(cast((time_remaining_cutting * quantity_same) as float) / 60, 2) end as [Time Remaining] , " +
                    "started_cut as [Start Time],date_cutting_complete as [Finish Time],priority_status_cut as [priority_status],dbo.door.cutting_note[Department Note] " +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id = " + staff_id + " AND dbo.door_allocation.department = 'cutting' AND complete_cutting = 0 and dbo.door.id > 100000";

            }

            if (department == "Prepping")
            {
                sql = "SELECT dbo.door_allocation.id,dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(cast((time_prep * quantity_same) as float) / 60,2) as [Total Time]," +
                    "case when complete_prep = -1 then 0 else round(cast((time_remaining_prepping * quantity_same) as float) / 60, 2) end as [Time Remaining] , " +
                    "started_prep as [Start Time],date_prepping_complete as [Finish Time],priority_status_prep as [priority_status],dbo.door.prepping_note[Department Note] " +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id = " + staff_id + " AND dbo.door_allocation.department = 'prepping' AND complete_prep = 0 and dbo.door.id > 100000";


            }
            if (department == "Assembly")
            {
                sql = "SELECT dbo.door_allocation.id,dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(cast((time_assembly * quantity_same) as float) / 60,2) as [Total Time], " +
                    "case when complete_assembly = -1 then 0 else round(cast((time_remianing_assembly * quantity_same) as float) / 60, 2) end as [Time Remaining] , " +
                    "started_assembly as [Start Time],date_assembly_complete as [Finish Time],priority_status_assembly as [priority_status],dbo.door.assembly_note[Department Note] " +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id =  " + staff_id + " AND dbo.door_allocation.department = 'assembly' AND complete_assembly = 0 and dbo.door.id > 100000";


            }
            if (department == "SL Buff")
            {
                sql = "SELECT dbo.door_allocation.id,dbo.door.id as [Door ID],RTRIM(s.[NAME]) as [Customer],round(cast((time_SL_buff * quantity_same) as float) / 60,2) as [Total Time], " +
                    "case when complete_SL_buff = -1 then 0 else round(cast((time_remaining_sl_buff * quantity_same) as float) / 60, 2) end as [Time Remaining] , " +
                    "started_SL_buff as [Start Time],date_SL_buff_complete as [Finish Time],priority_status_SL_buff as [priority_status],dbo.door.sl_buff_note[Department Note] " +
                    "FROM dbo.door_allocation LEFT JOIN dbo.door ON dbo.door_allocation.door_id = dbo.door.id LEFT JOIN dbo.SALES_LEDGER s on s.ACCOUNT_REF = dbo.door.customer_acc_ref " +
                    "WHERE dbo.door_allocation.staff_id =  " + staff_id + " AND dbo.door_allocation.department = 'sl buff' AND complete_SL_buff = 0 and dbo.door.id > 100000";

            }


            if (sql.Length > 0)
            {
                using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCurrentAllocations.DataSource = dt;
                        conn.Close();
                    }
                }
                //format here?
                current_id_index = dgvCurrentAllocations.Columns["id"].Index;
                current_door_id_index = dgvCurrentAllocations.Columns["Door ID"].Index;
                current_customer_index = dgvCurrentAllocations.Columns["Customer"].Index;
                current_total_time_index = dgvCurrentAllocations.Columns["Total Time"].Index;
                current_time_remaining_index = dgvCurrentAllocations.Columns["Time Remaining"].Index;
                current_start_time_index = dgvCurrentAllocations.Columns["Start Time"].Index;
                current_finish_time_index = dgvCurrentAllocations.Columns["Finish Time"].Index;
                current_priority_status_index = dgvCurrentAllocations.Columns["priority_status"].Index;
                current_dept_note_index = dgvCurrentAllocations.Columns["Department Note"].Index;
                //add X button here
                //
                int columnIndex = 0;
                columnIndex = current_dept_note_index + 1;
                DataGridViewButtonColumn xButton = new DataGridViewButtonColumn();
                xButton.Name = "X";
                xButton.Text = "X";
                xButton.UseColumnTextForButtonValue = true;
                if (dgvCurrentAllocations.Columns["X_column"] == null)
                    dgvCurrentAllocations.Columns.Insert(columnIndex, xButton);
                //

                if (dgvCurrentAllocations.Columns.Contains("X") == true)
                    current_remove_button = dgvCurrentAllocations.Columns["X"].Index;
                //hide columns
                dgvCurrentAllocations.Columns[current_priority_status_index].Visible = false;
                dgvCurrentAllocations.Columns[current_id_index].Visible = false;
                //auto all cells the others?
                foreach (DataGridViewColumn col in dgvCurrentAllocations.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                dgvCurrentAllocations.Columns[current_dept_note_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

        }

        private void dgvCurrentAllocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int current_user = 0;
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightSkyBlue)
                    current_user = Convert.ToInt32(row.Cells[1].Value);
            }
            if (dgvCurrentAllocations.Columns[e.ColumnIndex].Index == current_remove_button)
            {
                //remove this allocation 

                using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
                {

                    string sql = "DELETE  FROM dbo.door_allocation WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_id_index].Value.ToString();
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();

                    //get the correct departmentnote
                    string dept_note = "";
                    switch (department)
                    {
                        case "Bending":
                            dept_note = "bending_note";
                            break;
                        case "Welding":
                            dept_note = "welding_note";
                            break;
                        case "Dressing":
                            dept_note = "buffing_note";
                            break;
                        case "Painting":
                            dept_note = "painting_note";
                            break;
                        case "Packing":
                            dept_note = "packing_note";
                            break;
                        default:
                            dept_note = "skip";
                            break;
                    }

                    //get the users full name
                    string current_user_full_name = "";
                    sql = "SELECT forename + ' ' + surname FROM [user_info].dbo.[user] WHERE id = " + current_user.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        current_user_full_name = (string)cmd.ExecuteScalar().ToString();

                    if (dept_note != "skip")
                    {
                        //remove the door allocation
                        string op_allocation = "";
                        switch (department)
                        {
                            case "Bending":
                                op_allocation = "bend";
                                break;
                            case "Welding":
                                op_allocation = "weld";
                                break;
                            case "Dressing":
                                op_allocation = "buff";
                                break;
                            case "Painting":
                                op_allocation = "paint";
                                break;
                            case "Packing":
                                op_allocation = "pack";
                                break;
                            case "Cutting":
                                op_allocation = "cut";
                                break;
                            case "prepping":
                                op_allocation = "prep";
                                break;
                            case "assembly":
                                op_allocation = "assembly";
                                break;
                            case "SL Buff":
                                op_allocation = "sl_buff";
                                break;
                        }

                        sql = "UPDATE dbo.door SET " + op_allocation + "_staff_allocation = NULL WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            cmd.ExecuteNonQuery();

                        //from this point we ask if they would like to reallocate to ANOTHER employee
                        DialogResult reallocation = MessageBox.Show("Would you like to reallocate this door to someone else?", "Reallocate", MessageBoxButtons.YesNo);
                        if (reallocation == DialogResult.Yes)
                        {
                            frmReallocation frm = new frmReallocation(department);
                            frm.ShowDialog();

                            if (CONNECT.reallocation_cancelled == -1)
                            {
                                string note = "";
                                sql = "SELECT " + dept_note + " FROM dbo.door WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    note = (string)cmd.ExecuteScalar().ToString();
                                note = note + " DEALLOCATED FROM: " + current_user_full_name + " - " + DateTime.Now.ToString();
                                sql = "UPDATE dbo.door SET " + dept_note + " = '" + note + "' WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    cmd.ExecuteNonQuery();
                            } //cancel was hit so we insert the normal note
                            else
                            {
                                //create the new reallocated note
                                //get the new users ID
                                sql = "SELECT id FROM [user_info].dbo.[user] WHERE forename + ' ' + surname = '" + CONNECT.reallocation_staff_name + "'";
                                int new_staff_id = 0;
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    new_staff_id = Convert.ToInt32(cmd.ExecuteScalar());

                                //get the old note 
                                string note = "";
                                sql = "SELECT " + dept_note + " FROM dbo.door WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    note = (string)cmd.ExecuteScalar().ToString();
                                note = note + " [DOOR REALLOCATED FROM: " + current_user_full_name + " TO: " + CONNECT.reallocation_staff_name + " " + DateTime.Now.ToString() + "] ";
                                sql = "UPDATE dbo.door SET " + dept_note + " = '" + note + "' WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    cmd.ExecuteNonQuery();

                                sql = "INSERT INTO dbo.door_allocation (door_id, operation_date, department, staff_id,allocated_by) VALUES ( " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString() + ",GETDATE(),'" + department + "','" + new_staff_id + "','" + CONNECT.login_full_name + "');";
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                    cmd.ExecuteNonQuery();
                            }
                        }
                        else // we are not reallocating so 
                        {
                            //get the current note
                            string note = "";
                            sql = "SELECT " + dept_note + " FROM dbo.door WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                                note = (string)cmd.ExecuteScalar().ToString();
                            note = note + " DEALLOCATED FROM: " + current_user_full_name + " - " + DateTime.Now.ToString();
                            sql = "UPDATE dbo.door SET " + dept_note + " = '" + note + "' WHERE id = " + dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                                cmd.ExecuteNonQuery();

                        }
                    }
                    conn.Close();
                }

            }

            if (e.ColumnIndex == current_dept_note_index)
            {
                string department_note = "";
                switch (department)
                {
                    case "Bending":
                        department_note = "bending_note";
                        break;
                    case "Welding":
                        department_note = "welding_note";
                        break;
                    case "Dressing":
                        department_note = "buffing_note";
                        break;
                    case "Painting":
                        department_note = "painting_note";
                        break;
                    case "Packing":
                        department_note = "packing_note";
                        break;
                    case "Cutting":
                        department_note = "cutting_note";
                        break;
                    case "Prepping":
                        department_note = "prepping_note";
                        break;
                    case "Assembly":
                        department_note = "assembly_note";
                        break;
                    case "SL Buff":
                        department_note = "sl_buff_note";
                        break;
                }
                frmAppendNote frm = new frmAppendNote(department_note, Convert.ToInt32(dgvCurrentAllocations.Rows[e.RowIndex].Cells[current_door_id_index].Value.ToString()));
                frm.ShowDialog();

            }


            loadAllocation();
            loadStaff(department);

            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.Cells[1].Value.ToString() == current_user.ToString())
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }

            dgvStaff.ClearSelection();
            loadCurrentAllocations();

        }



        private void dgvAllocation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int skipRefresh = 0;
            int staff_id = 0;
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightSkyBlue)
                    staff_id = Convert.ToInt32(row.Cells[1].Value);
            }
            if (staff_id > 0 && e.ColumnIndex == door_id_index)
            {
                //check if staff allocation is null! (also if its allocation blocc then remove it and try next
                if (string.IsNullOrEmpty(dgvAllocation.Rows[e.RowIndex].Cells[staff_allocation_index].Value.ToString()) || dgvAllocation.Rows[e.RowIndex].Cells[staff_allocation_index].Value.ToString() == "Allocation Block ")
                {
                    using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
                    {
                        string sql = "";
                        string door_id = dgvAllocation.Rows[e.RowIndex].Cells[door_id_index].Value.ToString();
                        conn.Open();
                        //if its allocation block we need to very quickly delete their entry
                        if (dgvAllocation.Rows[e.RowIndex].Cells[staff_allocation_index].Value.ToString() == "Allocation Block ")
                        {
                            sql = "DELETE FROM dbo.door_allocation WHERE door_id = " + door_id + " AND department = '" + department + "'";
                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                                cmd.ExecuteNonQuery();

                        }

                        string staff_full_name = "";
                        sql = "SELECT forename + ' ' + surname FROM [user_info].dbo.[user] WHERE id = " + staff_id.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            staff_full_name = (string)cmd.ExecuteScalar().ToString();
                        //inser into door_allocation
                        sql = "INSERT INTO dbo.door_allocation (door_id, operation_date, department, staff_id,allocated_by) VALUES ( " + door_id + ",GETDATE(),'" + department + "','" + staff_id + "','" + CONNECT.login_full_name + "');";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            cmd.ExecuteNonQuery();

                        string op_allocation = "";
                        switch (department)
                        {
                            case "Bending":
                                op_allocation = "bend";
                                break;
                            case "Welding":
                                op_allocation = "weld";
                                break;
                            case "Dressing":
                                op_allocation = "buff";
                                break;
                            case "Painting":
                                op_allocation = "paint";
                                break;
                            case "Packing":
                                op_allocation = "pack";
                                break;
                            case "Cutting":
                                op_allocation = "cut";
                                break;
                            case "prepping":
                                op_allocation = "prep";
                                break;
                            case "assembly":
                                op_allocation = "assembly";
                                break;
                            case "SL Buff":
                                op_allocation = "sl_buff";
                                break;
                        }


                        sql = "UPDATE dbo.door SET " + op_allocation + "_staff_allocation = '" + staff_full_name + "' WHERE id = " + door_id;
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            cmd.ExecuteNonQuery();


                        string dept_note = "";
                        switch (department)
                        {
                            case "Bending":
                                dept_note = "bending_note";
                                break;
                            case "Welding":
                                dept_note = "welding_note";
                                break;
                            case "Dressing":
                                dept_note = "buffing_note";
                                break;
                            case "Painting":
                                dept_note = "painting_note";
                                break;
                            case "Packing":
                                dept_note = "packing_note";
                                break;
                            default:
                                dept_note = "skip";
                                break;
                        }

                        string note = "";
                        sql = "SELECT " + dept_note + " FROM dbo.door WHERE id = " + door_id.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            note = (string)cmd.ExecuteScalar().ToString();
                        note = note + "ALLOCATED TO: " + staff_full_name + " - " + DateTime.Now.ToString();
                        sql = "UPDATE dbo.door SET " + dept_note + " = '" + note + "' WHERE id = " + door_id;
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                }
            }

            if (e.ColumnIndex == order_info_index)
            {
                //open the order info screen
                frmOrderInfo frm = new frmOrderInfo(department, Convert.ToInt32(dgvAllocation.Rows[e.RowIndex].Cells[door_id_index].Value.ToString()));
                frm.ShowDialog();
                skipRefresh = -1;
            }

            if (e.ColumnIndex == complete_stores_index)
            {
                //open the order info screen
                frmNotes frm = new frmNotes(Convert.ToInt32(dgvAllocation.Rows[e.RowIndex].Cells[door_id_index].Value.ToString()));
                frm.ShowDialog();
            }

            if (e.ColumnIndex == staff_allocation_index)
            {
                string department_note = "";
                switch (department)
                {
                    case "Bending":
                        department_note = "bending_note";
                        break;
                    case "Welding":
                        department_note = "welding_note";
                        break;
                    case "Dressing":
                        department_note = "buffing_note";
                        break;
                    case "Painting":
                        department_note = "painting_note";
                        break;
                    case "Packing":
                        department_note = "packing_note";
                        break;
                    case "Cutting":
                        department_note = "cutting_note";
                        break;
                    case "Prepping":
                        department_note = "prepping_note";
                        break;
                    case "Assembly":
                        department_note = "assembly_note";
                        break;
                    case "SL Buff":
                        department_note = "sl_buff_note";
                        break;
                }
                frmDepartmentNote frm = new frmDepartmentNote(department, department_note, Convert.ToInt32(dgvAllocation.Rows[e.RowIndex].Cells[door_id_index].Value.ToString()));
                frm.ShowDialog();
            }

            if (e.ColumnIndex == urgent_button_index)
            {
                frmUrgent frm = new frmUrgent(Convert.ToInt32(dgvAllocation.Rows[e.RowIndex].Cells[door_id_index].Value.ToString()));
                frm.ShowDialog();
            }

            if (skipRefresh == 0)
            {
                loadAllocation();
                loadStaff(department);

                foreach (DataGridViewRow row in dgvStaff.Rows)
                {
                    if (row.Cells[1].Value.ToString() == staff_id.ToString())
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }

                dgvStaff.ClearSelection();
                loadCurrentAllocations();
            }


        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmReallocation frm = new frmReallocation(department);
            frm.ShowDialog();
            MessageBox.Show(CONNECT.reallocation_staff_name);
        }

        private void txtDoorID_Leave(object sender, EventArgs e)
        {
            loadAllocation();
        }

        private void txtDoorID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadAllocation();
            }
        }
    }
}
