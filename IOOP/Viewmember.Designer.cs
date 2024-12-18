namespace Assignment
{
    partial class Viewmember
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
            this.profilelist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.editprofilebtn = new System.Windows.Forms.Button();
            this.Dltbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profilelist
            // 
            this.profilelist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilelist.FormattingEnabled = true;
            this.profilelist.ItemHeight = 22;
            this.profilelist.Location = new System.Drawing.Point(356, 132);
            this.profilelist.Name = "profilelist";
            this.profilelist.Size = new System.Drawing.Size(361, 246);
            this.profilelist.TabIndex = 0;
            this.profilelist.SelectedIndexChanged += new System.EventHandler(this.profilelist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile List";
            // 
            // Viewbtn
            // 
            this.Viewbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Viewbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.Location = new System.Drawing.Point(159, 132);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(108, 55);
            this.Viewbtn.TabIndex = 2;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // editprofilebtn
            // 
            this.editprofilebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editprofilebtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editprofilebtn.Location = new System.Drawing.Point(159, 231);
            this.editprofilebtn.Name = "editprofilebtn";
            this.editprofilebtn.Size = new System.Drawing.Size(108, 52);
            this.editprofilebtn.TabIndex = 3;
            this.editprofilebtn.Text = "Edit";
            this.editprofilebtn.UseVisualStyleBackColor = false;
            this.editprofilebtn.Click += new System.EventHandler(this.editprofilebtn_Click);
            // 
            // Dltbtn
            // 
            this.Dltbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dltbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dltbtn.Location = new System.Drawing.Point(159, 328);
            this.Dltbtn.Name = "Dltbtn";
            this.Dltbtn.Size = new System.Drawing.Size(108, 53);
            this.Dltbtn.TabIndex = 4;
            this.Dltbtn.Text = "Delete";
            this.Dltbtn.UseVisualStyleBackColor = false;
            this.Dltbtn.Click += new System.EventHandler(this.Dltbtn_Click);
            // 
            // Viewmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dltbtn);
            this.Controls.Add(this.editprofilebtn);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profilelist);
            this.Name = "Viewmember";
            this.Text = "View/EditMember";
            this.Load += new System.EventHandler(this.Viewprofile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox profilelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Button editprofilebtn;
        private System.Windows.Forms.Button Dltbtn;
    }
}