namespace pm_manager
{
    partial class ViewWindow
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
            //this.LiveDataView = new pm_manager.DataView(false);

            this.LiveDataView = new pm_manager.DataView(false);
            this.SuspendLayout();
            // 
            // LiveDataView
            // 
            this.LiveDataView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LiveDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiveDataView.Location = new System.Drawing.Point(0, 0);
            this.LiveDataView.Name = "LiveDataView";
            this.LiveDataView.Size = new System.Drawing.Size(1459, 679);
            this.LiveDataView.TabIndex = 0;
            // 
            // ViewWindow
            // 
            this.AccessibleName = "View";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 679);
            this.Controls.Add(this.LiveDataView);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ViewWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ViewWindow";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private DataView LiveDataView;
    }
}