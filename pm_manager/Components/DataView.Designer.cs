using System.Drawing;

namespace pm_manager
{
    partial class DataView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HeaderLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeaderLabel.Size = new System.Drawing.Size(667, 44);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "HeaderText";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ContentLabel
            // 
            this.ContentLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(0, 44);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(667, 379);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content Text";
            this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "DataView";
            this.Size = new System.Drawing.Size(667, 423);
            this.Resize += new System.EventHandler(this.DataView_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label HeaderLabel;
        public System.Windows.Forms.Label ContentLabel;
    }
}