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
            this.LiveToggleBtn = new System.Windows.Forms.Button();
            this.viewToggleBtn = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.Panel();
            this.PreView = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabView = new System.Windows.Forms.TabControl();
            this.BibleView = new System.Windows.Forms.TabPage();
            this.ImageView = new System.Windows.Forms.TabPage();
            this.ImagesViewContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ImageViewControls = new System.Windows.Forms.Panel();
            this.AddImageBtn = new System.Windows.Forms.Button();
            this.PreviewPanel = new pm_manager.DataView(true);
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabView.SuspendLayout();
            this.ImageView.SuspendLayout();
            this.ImageViewControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // controls
            // 
            this.controls.AccessibleName = "Controls";
            this.controls.BackColor = System.Drawing.Color.White;
            this.controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controls.Controls.Add(this.button3);
            this.controls.Controls.Add(this.LiveToggleBtn);
            this.controls.Controls.Add(this.viewToggleBtn);
            this.controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.controls.Location = new System.Drawing.Point(0, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(1096, 46);
            this.controls.TabIndex = 0;
            this.controls.Paint += new System.Windows.Forms.PaintEventHandler(this.controls_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(174, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // LiveToggleBtn
            // 
            this.LiveToggleBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.LiveToggleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LiveToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveToggleBtn.Location = new System.Drawing.Point(93, 12);
            this.LiveToggleBtn.Name = "LiveToggleBtn";
            this.LiveToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.LiveToggleBtn.TabIndex = 1;
            this.LiveToggleBtn.Text = "isLive";
            this.LiveToggleBtn.UseVisualStyleBackColor = false;
            this.LiveToggleBtn.Click += new System.EventHandler(this.LiveToggleBtn_Click);
            // 
            // viewToggleBtn
            // 
            this.viewToggleBtn.AccessibleName = "open window";
            this.viewToggleBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.viewToggleBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.viewToggleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewToggleBtn.Location = new System.Drawing.Point(12, 12);
            this.viewToggleBtn.Name = "viewToggleBtn";
            this.viewToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.viewToggleBtn.TabIndex = 0;
            this.viewToggleBtn.Tag = "ViewToggleBtn";
            this.viewToggleBtn.Text = "Start view";
            this.viewToggleBtn.UseVisualStyleBackColor = false;
            this.viewToggleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataView
            // 
            this.DataView.AccessibleName = "playlists";
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataView.Location = new System.Drawing.Point(0, 535);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(1096, 37);
            this.DataView.TabIndex = 1;
            // 
            // PreView
            // 
            this.PreView.AccessibleName = "playlistHook panel";
            this.PreView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PreView.Location = new System.Drawing.Point(0, 308);
            this.PreView.Name = "PreView";
            this.PreView.Size = new System.Drawing.Size(1096, 227);
            this.PreView.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TabView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PreviewPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 262);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.TabIndex = 3;
            // 
            // TabView
            // 
            this.TabView.Controls.Add(this.BibleView);
            this.TabView.Controls.Add(this.ImageView);
            this.TabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabView.Location = new System.Drawing.Point(0, 0);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(541, 260);
            this.TabView.TabIndex = 0;
            // 
            // BibleView
            // 
            this.BibleView.AutoScroll = true;
            this.BibleView.BackColor = System.Drawing.Color.White;
            this.BibleView.Location = new System.Drawing.Point(4, 22);
            this.BibleView.Name = "BibleView";
            this.BibleView.Padding = new System.Windows.Forms.Padding(3);
            this.BibleView.Size = new System.Drawing.Size(533, 234);
            this.BibleView.TabIndex = 0;
            this.BibleView.Text = "BibleView";
            // 
            // ImageView
            // 
            this.ImageView.BackColor = System.Drawing.Color.White;
            this.ImageView.Controls.Add(this.ImagesViewContainer);
            this.ImageView.Controls.Add(this.ImageViewControls);
            this.ImageView.Location = new System.Drawing.Point(4, 22);
            this.ImageView.Name = "ImageView";
            this.ImageView.Padding = new System.Windows.Forms.Padding(3);
            this.ImageView.Size = new System.Drawing.Size(533, 234);
            this.ImageView.TabIndex = 1;
            this.ImageView.Text = "ImageView";
            // 
            // ImagesViewContainer
            // 
            this.ImagesViewContainer.AutoScroll = true;
            this.ImagesViewContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.ImagesViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagesViewContainer.Location = new System.Drawing.Point(3, 31);
            this.ImagesViewContainer.Name = "ImagesViewContainer";
            this.ImagesViewContainer.Padding = new System.Windows.Forms.Padding(8);
            this.ImagesViewContainer.Size = new System.Drawing.Size(527, 200);
            this.ImagesViewContainer.TabIndex = 1;
            // 
            // ImageViewControls
            // 
            this.ImageViewControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageViewControls.Controls.Add(this.AddImageBtn);
            this.ImageViewControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImageViewControls.Location = new System.Drawing.Point(3, 3);
            this.ImageViewControls.Margin = new System.Windows.Forms.Padding(0);
            this.ImageViewControls.Name = "ImageViewControls";
            this.ImageViewControls.Size = new System.Drawing.Size(527, 28);
            this.ImageViewControls.TabIndex = 0;
            // 
            // AddImageBtn
            // 
            this.AddImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImageBtn.Location = new System.Drawing.Point(5, 3);
            this.AddImageBtn.Name = "AddImageBtn";
            this.AddImageBtn.Size = new System.Drawing.Size(58, 21);
            this.AddImageBtn.TabIndex = 0;
            this.AddImageBtn.Text = "Add";
            this.AddImageBtn.UseVisualStyleBackColor = true;
            this.AddImageBtn.Click += new System.EventHandler(this.AddImageBtn_Click);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.BackColor = System.Drawing.Color.White;
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(0, 0);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(547, 260);
            this.PreviewPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AccessibleName = "Window";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1096, 572);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PreView);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.controls);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controls.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabView.ResumeLayout(false);
            this.ImageView.ResumeLayout(false);
            this.ImageViewControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Panel DataView;
        private System.Windows.Forms.Panel PreView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button LiveToggleBtn;
        public System.Windows.Forms.Button viewToggleBtn;
        private DataView PreviewPanel;
        private System.Windows.Forms.TabControl TabView;
        private System.Windows.Forms.TabPage BibleView;
        private System.Windows.Forms.TabPage ImageView;
        private System.Windows.Forms.Panel ImageViewControls;
        private System.Windows.Forms.Button AddImageBtn;
        private System.Windows.Forms.FlowLayoutPanel ImagesViewContainer;
    }
}

