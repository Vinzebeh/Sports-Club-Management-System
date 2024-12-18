namespace Assignment
{
    partial class Edit_Schedule
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
            this.cbDisplay = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDisplay
            // 
            this.cbDisplay.BackColor = System.Drawing.Color.AliceBlue;
            this.cbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplay.FormattingEnabled = true;
            this.cbDisplay.Location = new System.Drawing.Point(139, 166);
            this.cbDisplay.Name = "cbDisplay";
            this.cbDisplay.Size = new System.Drawing.Size(501, 24);
            this.cbDisplay.TabIndex = 0;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = " ";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(440, 225);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(200, 22);
            this.timePicker.TabIndex = 2;
            this.timePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timePicker_KeyDown);
            this.timePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timePicker_MouseDown);
            // 
            // cbDuration
            // 
            this.cbDuration.BackColor = System.Drawing.Color.AliceBlue;
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "30 mins",
            "1 hour",
            "1 hour 30 mins",
            "2 hours",
            "2 hours 30 mins"});
            this.cbDuration.Location = new System.Drawing.Point(440, 280);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(125, 24);
            this.cbDuration.TabIndex = 3;
            // 
            // txtVenue
            // 
            this.txtVenue.BackColor = System.Drawing.Color.AliceBlue;
            this.txtVenue.Location = new System.Drawing.Point(440, 333);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(125, 22);
            this.txtVenue.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(149, 225);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(226, 26);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Please set a new time : ";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDuration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(149, 280);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(263, 26);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Please enter new duration :";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVenue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(149, 333);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(241, 26);
            this.lblVenue.TabIndex = 8;
            this.lblVenue.Text = "Please enter new venue :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(207, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 49);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.AliceBlue;
            this.lblEdit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(214, 39);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(340, 37);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Edit Training Schedule";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(134, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(333, 26);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Selecte a training schedule to edit :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(410, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 49);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Edit_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.cbDuration);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.cbDisplay);
            this.Name = "Edit_Schedule";
            this.Text = "Edit_Schedule";
            this.Load += new System.EventHandler(this.Edit_Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDisplay;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBack;
    }
}