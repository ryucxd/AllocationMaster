namespace AllocationMaster
{
    partial class frmAllocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.chkBending = new System.Windows.Forms.CheckBox();
            this.chkWelding = new System.Windows.Forms.CheckBox();
            this.chkDressing = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.chkPacking = new System.Windows.Forms.CheckBox();
            this.chkCutting = new System.Windows.Forms.CheckBox();
            this.chkPrepping = new System.Windows.Forms.CheckBox();
            this.chkAssembly = new System.Windows.Forms.CheckBox();
            this.chkSLBuff = new System.Windows.Forms.CheckBox();
            this.dgvAllocation = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvCurrentAllocations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAllocations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.Location = new System.Drawing.Point(93, 12);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.Size = new System.Drawing.Size(198, 428);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellDoubleClick);
            // 
            // chkBending
            // 
            this.chkBending.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBending.Location = new System.Drawing.Point(12, 12);
            this.chkBending.Name = "chkBending";
            this.chkBending.Size = new System.Drawing.Size(71, 24);
            this.chkBending.TabIndex = 10;
            this.chkBending.Text = "Bending";
            this.chkBending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBending.UseVisualStyleBackColor = true;
            this.chkBending.CheckedChanged += new System.EventHandler(this.chkBending_CheckedChanged);
            // 
            // chkWelding
            // 
            this.chkWelding.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWelding.Location = new System.Drawing.Point(12, 42);
            this.chkWelding.Name = "chkWelding";
            this.chkWelding.Size = new System.Drawing.Size(71, 23);
            this.chkWelding.TabIndex = 11;
            this.chkWelding.Text = "Welding";
            this.chkWelding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkWelding.UseVisualStyleBackColor = true;
            this.chkWelding.CheckedChanged += new System.EventHandler(this.chkWelding_CheckedChanged);
            // 
            // chkDressing
            // 
            this.chkDressing.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDressing.Location = new System.Drawing.Point(12, 72);
            this.chkDressing.Name = "chkDressing";
            this.chkDressing.Size = new System.Drawing.Size(71, 23);
            this.chkDressing.TabIndex = 12;
            this.chkDressing.Text = "Dressing";
            this.chkDressing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDressing.UseVisualStyleBackColor = true;
            this.chkDressing.CheckedChanged += new System.EventHandler(this.chkDressing_CheckedChanged);
            // 
            // chkPainting
            // 
            this.chkPainting.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPainting.Location = new System.Drawing.Point(12, 102);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(71, 23);
            this.chkPainting.TabIndex = 13;
            this.chkPainting.Text = "Painting";
            this.chkPainting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPainting.UseVisualStyleBackColor = true;
            this.chkPainting.CheckedChanged += new System.EventHandler(this.chkPainting_CheckedChanged);
            // 
            // chkPacking
            // 
            this.chkPacking.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPacking.Location = new System.Drawing.Point(12, 132);
            this.chkPacking.Name = "chkPacking";
            this.chkPacking.Size = new System.Drawing.Size(71, 23);
            this.chkPacking.TabIndex = 14;
            this.chkPacking.Text = "Packing";
            this.chkPacking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPacking.UseVisualStyleBackColor = true;
            this.chkPacking.CheckedChanged += new System.EventHandler(this.chkPacking_CheckedChanged);
            // 
            // chkCutting
            // 
            this.chkCutting.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCutting.Location = new System.Drawing.Point(12, 162);
            this.chkCutting.Name = "chkCutting";
            this.chkCutting.Size = new System.Drawing.Size(71, 23);
            this.chkCutting.TabIndex = 15;
            this.chkCutting.Text = "Cutting";
            this.chkCutting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCutting.UseVisualStyleBackColor = true;
            this.chkCutting.CheckedChanged += new System.EventHandler(this.chkCutting_CheckedChanged);
            // 
            // chkPrepping
            // 
            this.chkPrepping.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrepping.Location = new System.Drawing.Point(12, 192);
            this.chkPrepping.Name = "chkPrepping";
            this.chkPrepping.Size = new System.Drawing.Size(71, 23);
            this.chkPrepping.TabIndex = 16;
            this.chkPrepping.Text = "Prepping";
            this.chkPrepping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrepping.UseVisualStyleBackColor = true;
            this.chkPrepping.CheckedChanged += new System.EventHandler(this.chkPrepping_CheckedChanged);
            // 
            // chkAssembly
            // 
            this.chkAssembly.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAssembly.Location = new System.Drawing.Point(12, 222);
            this.chkAssembly.Name = "chkAssembly";
            this.chkAssembly.Size = new System.Drawing.Size(71, 23);
            this.chkAssembly.TabIndex = 17;
            this.chkAssembly.Text = "Assembly";
            this.chkAssembly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAssembly.UseVisualStyleBackColor = true;
            this.chkAssembly.CheckedChanged += new System.EventHandler(this.chkAssembly_CheckedChanged);
            // 
            // chkSLBuff
            // 
            this.chkSLBuff.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSLBuff.Location = new System.Drawing.Point(12, 252);
            this.chkSLBuff.Name = "chkSLBuff";
            this.chkSLBuff.Size = new System.Drawing.Size(71, 23);
            this.chkSLBuff.TabIndex = 18;
            this.chkSLBuff.Text = "SL Buff";
            this.chkSLBuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSLBuff.UseVisualStyleBackColor = true;
            this.chkSLBuff.CheckedChanged += new System.EventHandler(this.chkSLBuff_CheckedChanged);
            // 
            // dgvAllocation
            // 
            this.dgvAllocation.AllowUserToAddRows = false;
            this.dgvAllocation.AllowUserToDeleteRows = false;
            this.dgvAllocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllocation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllocation.Location = new System.Drawing.Point(12, 446);
            this.dgvAllocation.Name = "dgvAllocation";
            this.dgvAllocation.RowHeadersVisible = false;
            this.dgvAllocation.Size = new System.Drawing.Size(1469, 452);
            this.dgvAllocation.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Violet;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(677, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 16);
            this.label19.TabIndex = 36;
            this.label19.Text = "Door ID =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(747, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Proving at Welding";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Door ID =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Not ready for allocation in Packing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "     ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Complete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(973, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Staff Allocation =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1085, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Department Note";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1211, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Weld Date =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1299, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Welding Started";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1211, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Buff Date =";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1299, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Buffing Started";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(524, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "     ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(553, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Allocation Block";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.MediumPurple;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(973, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "     ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1085, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "Priority Status";
            // 
            // dgvCurrentAllocations
            // 
            this.dgvCurrentAllocations.AllowUserToAddRows = false;
            this.dgvCurrentAllocations.AllowUserToDeleteRows = false;
            this.dgvCurrentAllocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentAllocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCurrentAllocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrentAllocations.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCurrentAllocations.Location = new System.Drawing.Point(297, 60);
            this.dgvCurrentAllocations.Name = "dgvCurrentAllocations";
            this.dgvCurrentAllocations.RowHeadersVisible = false;
            this.dgvCurrentAllocations.Size = new System.Drawing.Size(1184, 380);
            this.dgvCurrentAllocations.TabIndex = 51;
            this.dgvCurrentAllocations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentAllocations_CellClick);
            this.dgvCurrentAllocations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentAllocations_CellDoubleClick);
            // 
            // frmAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 910);
            this.Controls.Add(this.dgvCurrentAllocations);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvAllocation);
            this.Controls.Add(this.chkSLBuff);
            this.Controls.Add(this.chkAssembly);
            this.Controls.Add(this.chkPrepping);
            this.Controls.Add(this.chkCutting);
            this.Controls.Add(this.chkPacking);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkDressing);
            this.Controls.Add(this.chkWelding);
            this.Controls.Add(this.chkBending);
            this.Controls.Add(this.dgvStaff);
            this.Name = "frmAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAllocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.CheckBox chkBending;
        private System.Windows.Forms.CheckBox chkWelding;
        private System.Windows.Forms.CheckBox chkDressing;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.CheckBox chkPacking;
        private System.Windows.Forms.CheckBox chkCutting;
        private System.Windows.Forms.CheckBox chkPrepping;
        private System.Windows.Forms.CheckBox chkAssembly;
        private System.Windows.Forms.CheckBox chkSLBuff;
        private System.Windows.Forms.DataGridView dgvAllocation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvCurrentAllocations;
    }
}

