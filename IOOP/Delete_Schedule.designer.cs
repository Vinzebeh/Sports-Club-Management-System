namespace Assignment
{
    partial class Delete_Schedule
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
            this.clbDisplay = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbDisplay
            // 
            this.clbDisplay.BackColor = System.Drawing.Color.AliceBlue;
            this.clbDisplay.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDisplay.FormattingEnabled = true;
            this.clbDisplay.Location = new System.Drawing.Point(175, 148);
            this.clbDisplay.Name = "clbDisplay";
            this.clbDisplay.Size = new System.Drawing.Size(455, 208);
            this.clbDisplay.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(215, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDelete.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(208, 26);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(369, 37);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Delete Training Schedule";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(171, 123);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(364, 22);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select following training schedule to delete: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(441, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 53);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Delete_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.clbDisplay);
            this.Name = "Delete_Schedule";
            this.Text = "Delete_Schedule";
            this.Load += new System.EventHandler(this.Delete_Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnBack;
    }
}