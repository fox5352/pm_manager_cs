using pm_manager.Lib;

namespace pm_manager.Components
{
    partial class SlideBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderText = new System.Windows.Forms.Label();
            this.ContentText = new System.Windows.Forms.Label();
            this.clickManager = new ClickManager(this.SlideBox_Click, this.SlideBox_DoubleClick);
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.BackColor = System.Drawing.Color.Transparent;
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeaderText.Size = new System.Drawing.Size(210, 44);
            this.HeaderText.TabIndex = 1;
            this.HeaderText.Text = "HeaderText";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickManager.MouseDown);
            // 
            // ContentText
            // 
            this.ContentText.BackColor = System.Drawing.Color.Transparent;
            this.ContentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ContentText.Location = new System.Drawing.Point(0, 44);
            this.ContentText.Margin = new System.Windows.Forms.Padding(0);
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(210, 186);
            this.ContentText.TabIndex = 2;
            this.ContentText.Text = "ContentText";
            this.ContentText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickManager.MouseDown);
            // 
            // SlideBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ContentText);
            this.Controls.Add(this.HeaderText);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MinimumSize = new System.Drawing.Size(210, 230);
            this.Name = "SlideBox";
            this.Size = new System.Drawing.Size(210, 230);
            this.ResumeLayout(false);

        }

        #endregion

        private ClickManager clickManager;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label ContentText;
    }
}
