namespace Assignment
{
    partial class viewAssign
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
            this.lstViewAss = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblAssign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstViewAss
            // 
            this.lstViewAss.FormattingEnabled = true;
            this.lstViewAss.ItemHeight = 16;
            this.lstViewAss.Location = new System.Drawing.Point(193, 108);
            this.lstViewAss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstViewAss.Name = "lstViewAss";
            this.lstViewAss.Size = new System.Drawing.Size(323, 148);
            this.lstViewAss.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(308, 274);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 33);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssign.Location = new System.Drawing.Point(197, 41);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(305, 39);
            this.lblAssign.TabIndex = 2;
            this.lblAssign.Text = "View Assign member";
            // 
            // viewAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lblAssign);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lstViewAss);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewAssign";
            this.Text = "viewAssign";
            this.Load += new System.EventHandler(this.viewAssign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstViewAss;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblAssign;
    }
}