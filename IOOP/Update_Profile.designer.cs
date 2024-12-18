namespace Assignment
{
    partial class Update_Profile
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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPnum = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPnum = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.AliceBlue;
            this.lblUpdate.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(250, 44);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(222, 37);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "Update Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.AliceBlue;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(177, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblPnum
            // 
            this.lblPnum.AutoSize = true;
            this.lblPnum.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPnum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnum.Location = new System.Drawing.Point(177, 176);
            this.lblPnum.Name = "lblPnum";
            this.lblPnum.Size = new System.Drawing.Size(165, 26);
            this.lblPnum.TabIndex = 2;
            this.lblPnum.Text = "Phone Number :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(406, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPnum
            // 
            this.txtPnum.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPnum.Location = new System.Drawing.Point(406, 176);
            this.txtPnum.Name = "txtPnum";
            this.txtPnum.Size = new System.Drawing.Size(120, 22);
            this.txtPnum.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(182, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 53);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(406, 231);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(120, 22);
            this.txtPW.TabIndex = 6;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPW.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(177, 231);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(190, 26);
            this.lblPW.TabIndex = 7;
            this.lblPW.Text = "Change Password :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(390, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 53);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Update_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 422);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPnum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPnum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUpdate);
            this.Name = "Update_Profile";
            this.Text = "Update_Profile";
            this.Load += new System.EventHandler(this.Update_Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPnum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPnum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btnBack;
    }
}