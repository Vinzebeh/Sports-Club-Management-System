namespace Assignment
{
    partial class AddCompetition
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
            this.txtComp = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.Datepick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(390, 150);
            this.txtComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(132, 22);
            this.txtComp.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(316, 284);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(176, 152);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(163, 21);
            this.lblComp.TabIndex = 3;
            this.lblComp.Text = "Competition Name :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(176, 209);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(244, 70);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(221, 32);
            this.lblAdd.TabIndex = 5;
            this.lblAdd.Text = "Add Competition";
            // 
            // Datepick
            // 
            this.Datepick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datepick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datepick.Location = new System.Drawing.Point(390, 207);
            this.Datepick.Name = "Datepick";
            this.Datepick.Size = new System.Drawing.Size(132, 27);
            this.Datepick.TabIndex = 6;
            this.Datepick.ValueChanged += new System.EventHandler(this.Datepick_ValueChanged);
            // 
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.Datepick);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCompetition";
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.DateTimePicker Datepick;
    }
}