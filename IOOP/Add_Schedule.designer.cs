namespace Assignment
{
    partial class Add_Schedule
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboxDuration = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = " ";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(468, 110);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(129, 22);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.datePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = " ";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(468, 169);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(129, 22);
            this.timePicker.TabIndex = 1;
            this.timePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timePicker_KeyDown);
            this.timePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timePicker_MouseDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(202, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(199, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Please select a date :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(202, 167);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(190, 26);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Please pick a time :";
            // 
            // cboxDuration
            // 
            this.cboxDuration.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDuration.FormattingEnabled = true;
            this.cboxDuration.Items.AddRange(new object[] {
            "30 mins",
            "1 hour",
            "1 hour 30 mins",
            "2 hours",
            "2 hours 30 mins"});
            this.cboxDuration.Location = new System.Drawing.Point(468, 225);
            this.cboxDuration.Name = "cboxDuration";
            this.cboxDuration.Size = new System.Drawing.Size(129, 24);
            this.cboxDuration.TabIndex = 4;
            this.cboxDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxDuration_KeyDown);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDuration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(202, 225);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(205, 26);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration of session :";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVenue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(202, 283);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(180, 26);
            this.lblVenue.TabIndex = 6;
            this.lblVenue.Text = "Venue of session :";
            // 
            // txtVenue
            // 
            this.txtVenue.BackColor = System.Drawing.Color.AliceBlue;
            this.txtVenue.Location = new System.Drawing.Point(468, 283);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(129, 22);
            this.txtVenue.TabIndex = 7;
            this.txtVenue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVenue_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(232, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 58);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Schedule";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(258, 27);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(339, 37);
            this.lblAdd.TabIndex = 9;
            this.lblAdd.Text = "Add Training Schedule";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(444, 346);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 58);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Add_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 460);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.cboxDuration);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Name = "Add_Schedule";
            this.Text = "Add_Schedule";
            this.Load += new System.EventHandler(this.Add_Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboxDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnBack;
    }
}