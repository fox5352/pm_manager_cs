using System.Windows.Forms;
using pm_manager.Lib;

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
            //this.LyricBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LyricBtn
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LyricBtn";
            this.Size = new System.Drawing.Size(467, 30);
            this.TabIndex = 0;
            this.Text = "Text";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseVisualStyleBackColor = false;
            this.MouseDown += new MouseEventHandler(this.ClickManager.MouseDown);
            // 
            // LyricBtnContainer
            // 
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(220, 30);
            this.Name = "LyricBtnContainer";
            this.Size = new System.Drawing.Size(467, 30);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
