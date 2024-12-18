namespace Assignment
{
    partial class Adduser
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
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.cntnmtxtbox = new System.Windows.Forms.TextBox();
            this.slrtxtbox = new System.Windows.Forms.TextBox();
            this.adduserbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.coachlevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User Page";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(439, 112);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 22);
            this.nametxtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary(only for manager and coach)";
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(439, 160);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(100, 22);
            this.emailtxtbox.TabIndex = 6;
            // 
            // cntnmtxtbox
            // 
            this.cntnmtxtbox.Location = new System.Drawing.Point(439, 212);
            this.cntnmtxtbox.Name = "cntnmtxtbox";
            this.cntnmtxtbox.Size = new System.Drawing.Size(100, 22);
            this.cntnmtxtbox.TabIndex = 7;
            // 
            // slrtxtbox
            // 
            this.slrtxtbox.Location = new System.Drawing.Point(439, 267);
            this.slrtxtbox.Name = "slrtxtbox";
            this.slrtxtbox.Size = new System.Drawing.Size(100, 22);
            this.slrtxtbox.TabIndex = 8;
            // 
            // adduserbtn
            // 
            this.adduserbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserbtn.Location = new System.Drawing.Point(364, 369);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Size = new System.Drawing.Size(124, 55);
            this.adduserbtn.TabIndex = 9;
            this.adduserbtn.Text = "Add User";
            this.adduserbtn.UseVisualStyleBackColor = true;
            this.adduserbtn.Click += new System.EventHandler(this.adduserbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Level(Only for coach)";
            // 
            // coachlevel
            // 
            this.coachlevel.FormattingEnabled = true;
            this.coachlevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.coachlevel.Location = new System.Drawing.Point(439, 318);
            this.coachlevel.Name = "coachlevel";
            this.coachlevel.Size = new System.Drawing.Size(121, 24);
            this.coachlevel.TabIndex = 11;
            // 
            // Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coachlevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adduserbtn);
            this.Controls.Add(this.slrtxtbox);
            this.Controls.Add(this.cntnmtxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.label1);
            this.Name = "Adduser";
            this.Text = "Adduser";
            this.Load += new System.EventHandler(this.Adduser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox cntnmtxtbox;
        private System.Windows.Forms.TextBox slrtxtbox;
        private System.Windows.Forms.Button adduserbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox coachlevel;
    }
}