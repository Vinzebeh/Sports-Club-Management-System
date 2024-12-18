namespace Assignment
{
    partial class rec
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
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.txtNamecomp = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecord.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(267, 266);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(132, 50);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompName.Location = new System.Drawing.Point(148, 126);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(163, 21);
            this.lblCompName.TabIndex = 3;
            this.lblCompName.Text = "Competition Name :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(148, 186);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Result :";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(245, 53);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(177, 23);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "Record Competition";
            // 
            // txtNamecomp
            // 
            this.txtNamecomp.FormattingEnabled = true;
            this.txtNamecomp.Location = new System.Drawing.Point(366, 126);
            this.txtNamecomp.Name = "txtNamecomp";
            this.txtNamecomp.Size = new System.Drawing.Size(121, 24);
            this.txtNamecomp.TabIndex = 6;
            // 
            // txtResult
            // 
            this.txtResult.FormattingEnabled = true;
            this.txtResult.Items.AddRange(new object[] {
            "Win",
            "Lose"});
            this.txtResult.Location = new System.Drawing.Point(366, 182);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 24);
            this.txtResult.TabIndex = 7;
            // 
            // rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNamecomp);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.btnRecord);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rec";
            this.Text = "rec";
            this.Load += new System.EventHandler(this.rec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ComboBox txtNamecomp;
        private System.Windows.Forms.ComboBox txtResult;
    }
}