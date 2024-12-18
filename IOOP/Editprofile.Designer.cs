namespace Assignment
{
    partial class Editprofile
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
            this.label3 = new System.Windows.Forms.Label();
            this.Contxtbox = new System.Windows.Forms.TextBox();
            this.Salarytxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Emailtxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.coachlevelbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Profile ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary(only for coach and manager)";
            // 
            // Contxtbox
            // 
            this.Contxtbox.Location = new System.Drawing.Point(431, 177);
            this.Contxtbox.Name = "Contxtbox";
            this.Contxtbox.Size = new System.Drawing.Size(121, 22);
            this.Contxtbox.TabIndex = 3;
            // 
            // Salarytxtbox
            // 
            this.Salarytxtbox.Location = new System.Drawing.Point(431, 249);
            this.Salarytxtbox.Name = "Salarytxtbox";
            this.Salarytxtbox.Size = new System.Drawing.Size(121, 22);
            this.Salarytxtbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // Emailtxtbox
            // 
            this.Emailtxtbox.Location = new System.Drawing.Point(431, 119);
            this.Emailtxtbox.Name = "Emailtxtbox";
            this.Emailtxtbox.Size = new System.Drawing.Size(121, 22);
            this.Emailtxtbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 48);
            this.label5.TabIndex = 8;
            this.label5.Text = "Level(Only for coach)";
            // 
            // coachlevelbox
            // 
            this.coachlevelbox.FormattingEnabled = true;
            this.coachlevelbox.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.coachlevelbox.Location = new System.Drawing.Point(431, 317);
            this.coachlevelbox.Name = "coachlevelbox";
            this.coachlevelbox.Size = new System.Drawing.Size(121, 24);
            this.coachlevelbox.TabIndex = 9;
            // 
            // Editprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coachlevelbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Emailtxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Salarytxtbox);
            this.Controls.Add(this.Contxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Editprofile";
            this.Text = "Editprofile";
            this.Load += new System.EventHandler(this.Editprofile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contxtbox;
        private System.Windows.Forms.TextBox Salarytxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emailtxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox coachlevelbox;
    }
}