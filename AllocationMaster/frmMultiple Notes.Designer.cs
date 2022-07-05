namespace AllocationMaster
{
    partial class frmMultiple_Notes
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
            this.chkBending = new System.Windows.Forms.CheckBox();
            this.chkWelding = new System.Windows.Forms.CheckBox();
            this.chkBuffing = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.chkPacking = new System.Windows.Forms.CheckBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBending
            // 
            this.chkBending.AutoSize = true;
            this.chkBending.Location = new System.Drawing.Point(22, 62);
            this.chkBending.Name = "chkBending";
            this.chkBending.Size = new System.Drawing.Size(65, 17);
            this.chkBending.TabIndex = 0;
            this.chkBending.Text = "Bending";
            this.chkBending.UseVisualStyleBackColor = true;
            // 
            // chkWelding
            // 
            this.chkWelding.AutoSize = true;
            this.chkWelding.Location = new System.Drawing.Point(22, 91);
            this.chkWelding.Name = "chkWelding";
            this.chkWelding.Size = new System.Drawing.Size(65, 17);
            this.chkWelding.TabIndex = 1;
            this.chkWelding.Text = "Welding";
            this.chkWelding.UseVisualStyleBackColor = true;
            // 
            // chkBuffing
            // 
            this.chkBuffing.AutoSize = true;
            this.chkBuffing.Location = new System.Drawing.Point(22, 120);
            this.chkBuffing.Name = "chkBuffing";
            this.chkBuffing.Size = new System.Drawing.Size(59, 17);
            this.chkBuffing.TabIndex = 2;
            this.chkBuffing.Text = "Buffing";
            this.chkBuffing.UseVisualStyleBackColor = true;
            // 
            // chkPainting
            // 
            this.chkPainting.AutoSize = true;
            this.chkPainting.Location = new System.Drawing.Point(22, 149);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(64, 17);
            this.chkPainting.TabIndex = 3;
            this.chkPainting.Text = "Painting";
            this.chkPainting.UseVisualStyleBackColor = true;
            // 
            // chkPacking
            // 
            this.chkPacking.AutoSize = true;
            this.chkPacking.Location = new System.Drawing.Point(22, 178);
            this.chkPacking.Name = "chkPacking";
            this.chkPacking.Size = new System.Drawing.Size(65, 17);
            this.chkPacking.TabIndex = 4;
            this.chkPacking.Text = "Packing";
            this.chkPacking.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(93, 62);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(330, 133);
            this.txtNote.TabIndex = 5;
            this.txtNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the departments you would like to add the same note to.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(348, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMultiple_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 231);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.chkPacking);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkBuffing);
            this.Controls.Add(this.chkWelding);
            this.Controls.Add(this.chkBending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultiple_Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Department Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBending;
        private System.Windows.Forms.CheckBox chkWelding;
        private System.Windows.Forms.CheckBox chkBuffing;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.CheckBox chkPacking;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}