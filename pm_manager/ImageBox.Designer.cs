namespace pm_manager
{
    partial class ImageBox
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
            this.ImageBoxContainer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBoxContainer
            // 
            this.ImageBoxContainer.BackColor = System.Drawing.Color.White;
            this.ImageBoxContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.ImageBoxContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ImageBoxContainer.Name = "ImageBoxContainer";
            this.ImageBoxContainer.Size = new System.Drawing.Size(150, 120);
            this.ImageBoxContainer.TabIndex = 0;
            this.ImageBoxContainer.TabStop = false;
            // 
            // ImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ImageBoxContainer);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ImageBox";
            this.Size = new System.Drawing.Size(150, 120);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBoxContainer;
    }
}
