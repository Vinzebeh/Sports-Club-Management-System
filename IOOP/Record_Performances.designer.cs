namespace Assignment
{
    partial class Record_Performances
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
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.cbStud = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbPerformances = new System.Windows.Forms.GroupBox();
            this.rbtnExcellent = new System.Windows.Forms.RadioButton();
            this.rbtnGood = new System.Windows.Forms.RadioButton();
            this.rbtnWeak = new System.Windows.Forms.RadioButton();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbPerformances.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRecord
            // 
            this.txtRecord.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRecord.Location = new System.Drawing.Point(402, 216);
            this.txtRecord.Multiline = true;
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(294, 81);
            this.txtRecord.TabIndex = 0;
            // 
            // cbStud
            // 
            this.cbStud.BackColor = System.Drawing.Color.AliceBlue;
            this.cbStud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStud.FormattingEnabled = true;
            this.cbStud.Location = new System.Drawing.Point(351, 109);
            this.cbStud.Name = "cbStud";
            this.cbStud.Size = new System.Drawing.Size(223, 24);
            this.cbStud.TabIndex = 1;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRecord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(229, 431);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(133, 47);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRecord.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(222, 30);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(326, 37);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "Record Performances";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.AliceBlue;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(166, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Member Name : ";
            // 
            // gbPerformances
            // 
            this.gbPerformances.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPerformances.Controls.Add(this.rbtnExcellent);
            this.gbPerformances.Controls.Add(this.rbtnGood);
            this.gbPerformances.Controls.Add(this.rbtnWeak);
            this.gbPerformances.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPerformances.Location = new System.Drawing.Point(134, 167);
            this.gbPerformances.Name = "gbPerformances";
            this.gbPerformances.Size = new System.Drawing.Size(226, 234);
            this.gbPerformances.TabIndex = 8;
            this.gbPerformances.TabStop = false;
            this.gbPerformances.Text = "Performances";
            // 
            // rbtnExcellent
            // 
            this.rbtnExcellent.AutoSize = true;
            this.rbtnExcellent.BackColor = System.Drawing.Color.AliceBlue;
            this.rbtnExcellent.Location = new System.Drawing.Point(27, 183);
            this.rbtnExcellent.Name = "rbtnExcellent";
            this.rbtnExcellent.Size = new System.Drawing.Size(117, 30);
            this.rbtnExcellent.TabIndex = 2;
            this.rbtnExcellent.TabStop = true;
            this.rbtnExcellent.Text = "Excellent";
            this.rbtnExcellent.UseVisualStyleBackColor = false;
            // 
            // rbtnGood
            // 
            this.rbtnGood.AutoSize = true;
            this.rbtnGood.BackColor = System.Drawing.Color.AliceBlue;
            this.rbtnGood.Location = new System.Drawing.Point(27, 114);
            this.rbtnGood.Name = "rbtnGood";
            this.rbtnGood.Size = new System.Drawing.Size(85, 30);
            this.rbtnGood.TabIndex = 1;
            this.rbtnGood.TabStop = true;
            this.rbtnGood.Text = "Good";
            this.rbtnGood.UseVisualStyleBackColor = false;
            // 
            // rbtnWeak
            // 
            this.rbtnWeak.AutoSize = true;
            this.rbtnWeak.BackColor = System.Drawing.Color.AliceBlue;
            this.rbtnWeak.Location = new System.Drawing.Point(27, 49);
            this.rbtnWeak.Name = "rbtnWeak";
            this.rbtnWeak.Size = new System.Drawing.Size(84, 30);
            this.rbtnWeak.TabIndex = 0;
            this.rbtnWeak.TabStop = true;
            this.rbtnWeak.Text = "Weak";
            this.rbtnWeak.UseVisualStyleBackColor = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.AliceBlue;
            this.lblComment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(397, 178);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(120, 26);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Comment ：";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(426, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 47);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Record_Performances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.gbPerformances);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.cbStud);
            this.Controls.Add(this.txtRecord);
            this.Name = "Record_Performances";
            this.Text = "Record_Performances";
            this.Load += new System.EventHandler(this.Record_Performances_Load);
            this.gbPerformances.ResumeLayout(false);
            this.gbPerformances.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.ComboBox cbStud;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbPerformances;
        private System.Windows.Forms.RadioButton rbtnExcellent;
        private System.Windows.Forms.RadioButton rbtnGood;
        private System.Windows.Forms.RadioButton rbtnWeak;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnBack;
    }
}