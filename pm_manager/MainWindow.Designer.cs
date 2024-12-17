namespace pm_manager
{
    partial class MainWindow
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
            this.controls = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.viewToggleBtn = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.Panel();
            this.PreView = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controls
            // 
            this.controls.AccessibleName = "Controls";
            this.controls.BackColor = System.Drawing.Color.White;
            this.controls.Controls.Add(this.button3);
            this.controls.Controls.Add(this.button2);
            this.controls.Controls.Add(this.viewToggleBtn);
            this.controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.controls.Location = new System.Drawing.Point(0, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(1350, 46);
            this.controls.TabIndex = 0;
            this.controls.Paint += new System.Windows.Forms.PaintEventHandler(this.controls_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // viewToggleBtn
            // 
            this.viewToggleBtn.AccessibleName = "open window";
            this.viewToggleBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.viewToggleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewToggleBtn.Location = new System.Drawing.Point(12, 12);
            this.viewToggleBtn.Name = "viewToggleBtn";
            this.viewToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.viewToggleBtn.TabIndex = 0;
            this.viewToggleBtn.Tag = "ViewToggleBtn";
            this.viewToggleBtn.Text = "Start view";
            this.viewToggleBtn.UseVisualStyleBackColor = true;
            this.viewToggleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataView
            // 
            this.DataView.AccessibleName = "playlists";
            this.DataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataView.Location = new System.Drawing.Point(0, 692);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(1350, 37);
            this.DataView.TabIndex = 1;
            // 
            // PreView
            // 
            this.PreView.AccessibleName = "playlist panel";
            this.PreView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PreView.Location = new System.Drawing.Point(0, 465);
            this.PreView.Name = "PreView";
            this.PreView.Size = new System.Drawing.Size(1350, 227);
            this.PreView.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1350, 419);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AccessibleName = "Window";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PreView);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.controls);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Panel DataView;
        private System.Windows.Forms.Panel PreView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button viewToggleBtn;
    }
}

