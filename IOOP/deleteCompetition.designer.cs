namespace Assignment
{
    partial class deleteCompetition
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
            this.lstDlt = new System.Windows.Forms.ListBox();
            this.btnDlt = new System.Windows.Forms.Button();
            this.lblDlt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDlt
            // 
            this.lstDlt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDlt.FormattingEnabled = true;
            this.lstDlt.ItemHeight = 15;
            this.lstDlt.Location = new System.Drawing.Point(253, 67);
            this.lstDlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDlt.Name = "lstDlt";
            this.lstDlt.Size = new System.Drawing.Size(163, 199);
            this.lstDlt.TabIndex = 0;
            // 
            // btnDlt
            // 
            this.btnDlt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDlt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.Location = new System.Drawing.Point(276, 306);
            this.btnDlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(126, 44);
            this.btnDlt.TabIndex = 2;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = false;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // lblDlt
            // 
            this.lblDlt.AutoSize = true;
            this.lblDlt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDlt.Location = new System.Drawing.Point(236, 28);
            this.lblDlt.Name = "lblDlt";
            this.lblDlt.Size = new System.Drawing.Size(191, 26);
            this.lblDlt.TabIndex = 3;
            this.lblDlt.Text = "Delete Competition";
            this.lblDlt.Click += new System.EventHandler(this.lblDlt_Click);
            // 
            // deleteCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lblDlt);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.lstDlt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "deleteCompetition";
            this.Text = "deleteCompetition";
            this.Load += new System.EventHandler(this.deleteCompetition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDlt;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Label lblDlt;
    }
}