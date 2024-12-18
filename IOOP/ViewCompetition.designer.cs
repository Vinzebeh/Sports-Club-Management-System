namespace Assignment
{
    partial class ViewCompetition
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
            this.lstComp = new System.Windows.Forms.ListBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.lblRec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstComp
            // 
            this.lstComp.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComp.FormattingEnabled = true;
            this.lstComp.ItemHeight = 15;
            this.lstComp.Location = new System.Drawing.Point(279, 130);
            this.lstComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstComp.Name = "lstComp";
            this.lstComp.Size = new System.Drawing.Size(163, 109);
            this.lstComp.TabIndex = 0;
            this.lstComp.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(307, 277);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(95, 45);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRec.Location = new System.Drawing.Point(178, 46);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(350, 37);
            this.lblRec.TabIndex = 2;
            this.lblRec.Text = "View Reccomend Student";
            // 
            // ViewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.lstComp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewCompetition";
            this.Text = "ViewCompetition";
            this.Load += new System.EventHandler(this.ViewCompetition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstComp;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label lblRec;
    }
}