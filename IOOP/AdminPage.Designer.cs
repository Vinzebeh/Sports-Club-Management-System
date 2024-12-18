namespace Assignment
{
    partial class AdminPage
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
            this.Addmemberbtn = new System.Windows.Forms.Button();
            this.identitylbl = new System.Windows.Forms.Label();
            this.viewincomebtn = new System.Windows.Forms.Button();
            this.compesumbtn = new System.Windows.Forms.Button();
            this.Updateprofilebtn = new System.Windows.Forms.Button();
            this.viewsuggbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Home Page ";
            // 
            // Addmemberbtn
            // 
            this.Addmemberbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addmemberbtn.Location = new System.Drawing.Point(200, 187);
            this.Addmemberbtn.Name = "Addmemberbtn";
            this.Addmemberbtn.Size = new System.Drawing.Size(152, 61);
            this.Addmemberbtn.TabIndex = 1;
            this.Addmemberbtn.Text = "Account Management ";
            this.Addmemberbtn.UseVisualStyleBackColor = true;
            this.Addmemberbtn.Click += new System.EventHandler(this.Addmemberbtn_Click);
            // 
            // identitylbl
            // 
            this.identitylbl.AutoSize = true;
            this.identitylbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identitylbl.Location = new System.Drawing.Point(281, 132);
            this.identitylbl.Name = "identitylbl";
            this.identitylbl.Size = new System.Drawing.Size(0, 22);
            this.identitylbl.TabIndex = 2;
            // 
            // viewincomebtn
            // 
            this.viewincomebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewincomebtn.Location = new System.Drawing.Point(422, 187);
            this.viewincomebtn.Name = "viewincomebtn";
            this.viewincomebtn.Size = new System.Drawing.Size(152, 61);
            this.viewincomebtn.TabIndex = 3;
            this.viewincomebtn.Text = "View Monthly Income";
            this.viewincomebtn.UseVisualStyleBackColor = true;
            this.viewincomebtn.Click += new System.EventHandler(this.viewincomebtn_Click);
            // 
            // compesumbtn
            // 
            this.compesumbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compesumbtn.Location = new System.Drawing.Point(110, 301);
            this.compesumbtn.Name = "compesumbtn";
            this.compesumbtn.Size = new System.Drawing.Size(152, 61);
            this.compesumbtn.TabIndex = 4;
            this.compesumbtn.Text = "Competition summary";
            this.compesumbtn.UseVisualStyleBackColor = true;
            this.compesumbtn.Click += new System.EventHandler(this.compesumbtn_Click);
            // 
            // Updateprofilebtn
            // 
            this.Updateprofilebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updateprofilebtn.Location = new System.Drawing.Point(527, 301);
            this.Updateprofilebtn.Name = "Updateprofilebtn";
            this.Updateprofilebtn.Size = new System.Drawing.Size(152, 61);
            this.Updateprofilebtn.TabIndex = 5;
            this.Updateprofilebtn.Text = "Update Profile";
            this.Updateprofilebtn.UseVisualStyleBackColor = true;
            this.Updateprofilebtn.Click += new System.EventHandler(this.Updateprofilebtn_Click);
            // 
            // viewsuggbtn
            // 
            this.viewsuggbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsuggbtn.Location = new System.Drawing.Point(322, 301);
            this.viewsuggbtn.Name = "viewsuggbtn";
            this.viewsuggbtn.Size = new System.Drawing.Size(152, 61);
            this.viewsuggbtn.TabIndex = 6;
            this.viewsuggbtn.Text = "View Member Suggestion";
            this.viewsuggbtn.UseVisualStyleBackColor = true;
            this.viewsuggbtn.Click += new System.EventHandler(this.viewsuggbtn_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewsuggbtn);
            this.Controls.Add(this.Updateprofilebtn);
            this.Controls.Add(this.compesumbtn);
            this.Controls.Add(this.viewincomebtn);
            this.Controls.Add(this.identitylbl);
            this.Controls.Add(this.Addmemberbtn);
            this.Controls.Add(this.label1);
            this.Name = "AdminPage";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addmemberbtn;
        private System.Windows.Forms.Label identitylbl;
        private System.Windows.Forms.Button viewincomebtn;
        private System.Windows.Forms.Button compesumbtn;
        private System.Windows.Forms.Button Updateprofilebtn;
        private System.Windows.Forms.Button viewsuggbtn;
    }
}