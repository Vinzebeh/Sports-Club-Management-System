namespace Assignment
{
    partial class AssignStud
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.lstComp = new System.Windows.Forms.ListBox();
            this.lblAssigntxt = new System.Windows.Forms.Label();
            this.lblStudAss = new System.Windows.Forms.Label();
            this.lblAss = new System.Windows.Forms.Label();
            this.lstStud = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssign.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(300, 310);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(94, 31);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lstComp
            // 
            this.lstComp.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComp.FormattingEnabled = true;
            this.lstComp.ItemHeight = 15;
            this.lstComp.Location = new System.Drawing.Point(100, 146);
            this.lstComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstComp.Name = "lstComp";
            this.lstComp.Size = new System.Drawing.Size(119, 124);
            this.lstComp.TabIndex = 1;
            this.lstComp.SelectedIndexChanged += new System.EventHandler(this.lstComp_SelectedIndexChanged);
            // 
            // lblAssigntxt
            // 
            this.lblAssigntxt.AutoSize = true;
            this.lblAssigntxt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssigntxt.Location = new System.Drawing.Point(11, 107);
            this.lblAssigntxt.Name = "lblAssigntxt";
            this.lblAssigntxt.Size = new System.Drawing.Size(296, 17);
            this.lblAssigntxt.TabIndex = 3;
            this.lblAssigntxt.Text = "Please select the competition you wish to assign :";
            // 
            // lblStudAss
            // 
            this.lblStudAss.AutoSize = true;
            this.lblStudAss.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudAss.Location = new System.Drawing.Point(389, 107);
            this.lblStudAss.Name = "lblStudAss";
            this.lblStudAss.Size = new System.Drawing.Size(271, 17);
            this.lblStudAss.TabIndex = 4;
            this.lblStudAss.Text = "Please select the student you wish to assign :";
            // 
            // lblAss
            // 
            this.lblAss.AutoSize = true;
            this.lblAss.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAss.Location = new System.Drawing.Point(172, 29);
            this.lblAss.Name = "lblAss";
            this.lblAss.Size = new System.Drawing.Size(324, 25);
            this.lblAss.TabIndex = 5;
            this.lblAss.Text = "Assign student into competition";
            // 
            // lstStud
            // 
            this.lstStud.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStud.FormattingEnabled = true;
            this.lstStud.Location = new System.Drawing.Point(464, 146);
            this.lstStud.Name = "lstStud";
            this.lstStud.Size = new System.Drawing.Size(124, 123);
            this.lstStud.TabIndex = 6;
            // 
            // AssignStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lstStud);
            this.Controls.Add(this.lblAss);
            this.Controls.Add(this.lblStudAss);
            this.Controls.Add(this.lblAssigntxt);
            this.Controls.Add(this.lstComp);
            this.Controls.Add(this.btnAssign);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AssignStud";
            this.Text = "AssignStud";
            this.Load += new System.EventHandler(this.AssignStud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ListBox lstComp;
        private System.Windows.Forms.Label lblAssigntxt;
        private System.Windows.Forms.Label lblStudAss;
        private System.Windows.Forms.Label lblAss;
        private System.Windows.Forms.CheckedListBox lstStud;
    }
}