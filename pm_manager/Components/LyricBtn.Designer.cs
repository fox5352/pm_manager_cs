namespace pm_manager.Components
{
    partial class LyricBtnContainer
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
            this.LyricBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LyricBtn
            // 
            this.LyricBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LyricBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LyricBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LyricBtn.Location = new System.Drawing.Point(0, 0);
            this.LyricBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LyricBtn.Name = "LyricBtn";
            this.LyricBtn.Size = new System.Drawing.Size(467, 30);
            this.LyricBtn.TabIndex = 0;
            this.LyricBtn.Text = "Text";
            this.LyricBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LyricBtn.UseVisualStyleBackColor = false;
            // 
            // LyricBtnContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LyricBtn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(220, 30);
            this.Name = "LyricBtnContainer";
            this.Size = new System.Drawing.Size(467, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LyricBtn;
    }
}
