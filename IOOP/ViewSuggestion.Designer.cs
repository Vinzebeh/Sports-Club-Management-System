namespace Assignment
{
    partial class ViewSuggestion
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
            this.viewsugglst = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // viewsugglst
            // 
            this.viewsugglst.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsugglst.HideSelection = false;
            this.viewsugglst.Location = new System.Drawing.Point(77, 61);
            this.viewsugglst.Name = "viewsugglst";
            this.viewsugglst.Size = new System.Drawing.Size(639, 342);
            this.viewsugglst.TabIndex = 0;
            this.viewsugglst.UseCompatibleStateImageBehavior = false;
            // 
            // ViewSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewsugglst);
            this.Name = "ViewSuggestion";
            this.Text = "ViewSuggestion";
            this.Load += new System.EventHandler(this.ViewSuggestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewsugglst;
    }
}