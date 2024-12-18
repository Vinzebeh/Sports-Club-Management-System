namespace Assignment
{
    partial class viewincome
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
            this.incomelist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // incomelist
            // 
            this.incomelist.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelist.HideSelection = false;
            this.incomelist.Location = new System.Drawing.Point(46, 31);
            this.incomelist.Name = "incomelist";
            this.incomelist.Size = new System.Drawing.Size(704, 390);
            this.incomelist.TabIndex = 0;
            this.incomelist.UseCompatibleStateImageBehavior = false;
            // 
            // viewincome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incomelist);
            this.Name = "viewincome";
            this.Text = "viewincome";
            this.Load += new System.EventHandler(this.viewincome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView incomelist;
    }
}