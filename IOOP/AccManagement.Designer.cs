namespace Assignment
{
    partial class AccManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addaccbtn = new System.Windows.Forms.Button();
            this.viewprofilebtn = new System.Windows.Forms.Button();
            this.Acctype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Management Page ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select account type to manage: ";
            // 
            // addaccbtn
            // 
            this.addaccbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addaccbtn.Location = new System.Drawing.Point(226, 323);
            this.addaccbtn.Name = "addaccbtn";
            this.addaccbtn.Size = new System.Drawing.Size(125, 76);
            this.addaccbtn.TabIndex = 4;
            this.addaccbtn.Text = "Add Account";
            this.addaccbtn.UseVisualStyleBackColor = true;
            this.addaccbtn.Click += new System.EventHandler(this.addaccbtn_Click);
            // 
            // viewprofilebtn
            // 
            this.viewprofilebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewprofilebtn.Location = new System.Drawing.Point(430, 323);
            this.viewprofilebtn.Name = "viewprofilebtn";
            this.viewprofilebtn.Size = new System.Drawing.Size(136, 76);
            this.viewprofilebtn.TabIndex = 6;
            this.viewprofilebtn.Text = "View/Edit Profile ";
            this.viewprofilebtn.UseVisualStyleBackColor = true;
            this.viewprofilebtn.Click += new System.EventHandler(this.viewprofilebtn_Click);
            // 
            // Acctype
            // 
            this.Acctype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acctype.FormattingEnabled = true;
            this.Acctype.Items.AddRange(new object[] {
            "Member",
            "Coach",
            "Manager"});
            this.Acctype.Location = new System.Drawing.Point(466, 160);
            this.Acctype.Name = "Acctype";
            this.Acctype.Size = new System.Drawing.Size(141, 30);
            this.Acctype.TabIndex = 7;
            this.Acctype.SelectedIndexChanged += new System.EventHandler(this.Acctype_SelectedIndexChanged);
            // 
            // AccManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Acctype);
            this.Controls.Add(this.viewprofilebtn);
            this.Controls.Add(this.addaccbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccManagement";
            this.Text = "AccManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addaccbtn;
        private System.Windows.Forms.Button viewprofilebtn;
        private System.Windows.Forms.ComboBox Acctype;
    }
}