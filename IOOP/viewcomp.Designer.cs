namespace Assignment
{
    partial class viewcomp
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
            this.compview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // compview
            // 
            this.compview.HideSelection = false;
            this.compview.Location = new System.Drawing.Point(143, 71);
            this.compview.Name = "compview";
            this.compview.Size = new System.Drawing.Size(541, 324);
            this.compview.TabIndex = 0;
            this.compview.UseCompatibleStateImageBehavior = false;
            // 
            // viewcomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compview);
            this.Name = "viewcomp";
            this.Text = "viewcomp";
            this.Load += new System.EventHandler(this.viewcomp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView compview;
    }
}