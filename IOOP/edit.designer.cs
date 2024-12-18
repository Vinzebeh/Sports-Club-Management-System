namespace Assignment
{
    partial class edit
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
            this.lstEditComp = new System.Windows.Forms.ListBox();
            this.btnSuccEdit = new System.Windows.Forms.Button();
            this.lblEditDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEditComp
            // 
            this.lstEditComp.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEditComp.FormattingEnabled = true;
            this.lstEditComp.ItemHeight = 15;
            this.lstEditComp.Location = new System.Drawing.Point(275, 90);
            this.lstEditComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEditComp.Name = "lstEditComp";
            this.lstEditComp.Size = new System.Drawing.Size(173, 154);
            this.lstEditComp.TabIndex = 0;
            // 
            // btnSuccEdit
            // 
            this.btnSuccEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuccEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccEdit.Location = new System.Drawing.Point(321, 289);
            this.btnSuccEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuccEdit.Name = "btnSuccEdit";
            this.btnSuccEdit.Size = new System.Drawing.Size(79, 43);
            this.btnSuccEdit.TabIndex = 1;
            this.btnSuccEdit.Text = "Edit";
            this.btnSuccEdit.UseVisualStyleBackColor = false;
            this.btnSuccEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEditDate
            // 
            this.lblEditDate.AutoSize = true;
            this.lblEditDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDate.Location = new System.Drawing.Point(171, 46);
            this.lblEditDate.Name = "lblEditDate";
            this.lblEditDate.Size = new System.Drawing.Size(368, 20);
            this.lblEditDate.TabIndex = 2;
            this.lblEditDate.Text = "Please select the competition that you wish to edit :";
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lblEditDate);
            this.Controls.Add(this.btnSuccEdit);
            this.Controls.Add(this.lstEditComp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "edit";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEditComp;
        private System.Windows.Forms.Button btnSuccEdit;
        private System.Windows.Forms.Label lblEditDate;
    }
}