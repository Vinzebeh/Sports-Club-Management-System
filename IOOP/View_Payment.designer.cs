namespace Assignment
{
    partial class View_Payment
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
            this.lblView = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvPaid = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.BackColor = System.Drawing.Color.AliceBlue;
            this.lblView.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(196, 36);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(368, 37);
            this.lblView.TabIndex = 1;
            this.lblView.Text = "View Member\'s Payment";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(319, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 47);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvPaid
            // 
            this.lvPaid.BackColor = System.Drawing.Color.AliceBlue;
            this.lvPaid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPaid.HideSelection = false;
            this.lvPaid.Location = new System.Drawing.Point(214, 101);
            this.lvPaid.Name = "lvPaid";
            this.lvPaid.Size = new System.Drawing.Size(335, 228);
            this.lvPaid.TabIndex = 12;
            this.lvPaid.UseCompatibleStateImageBehavior = false;
            // 
            // View_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.lvPaid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblView);
            this.Name = "View_Payment";
            this.Text = "View_Payment";
            this.Load += new System.EventHandler(this.View_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvPaid;
    }
}