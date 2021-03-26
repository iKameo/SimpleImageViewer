namespace SimpleImageViewer
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.st_Bottom = new System.Windows.Forms.StatusStrip();
            this.stlbl_path = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_sizeMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strechImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Delete = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_Rotate_left = new System.Windows.Forms.ToolStripDropDownButton();
            this.pb_mainView = new System.Windows.Forms.PictureBox();
            this.mnu_Main.SuspendLayout();
            this.st_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainView)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_Main
            // 
            this.mnu_Main.AllowDrop = true;
            this.mnu_Main.BackColor = System.Drawing.Color.Transparent;
            this.mnu_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analyzeToolStripMenuItem});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Size = new System.Drawing.Size(784, 24);
            this.mnu_Main.TabIndex = 1;
            this.mnu_Main.Text = "mnu_Main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            this.analyzeToolStripMenuItem.Click += new System.EventHandler(this.analyzeToolStripMenuItem_Click);
            // 
            // st_Bottom
            // 
            this.st_Bottom.AllowDrop = true;
            this.st_Bottom.BackColor = System.Drawing.Color.Transparent;
            this.st_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlbl_path,
            this.ts_sizeMode,
            this.ts_Delete,
            this.ts_Rotate_left});
            this.st_Bottom.Location = new System.Drawing.Point(0, 539);
            this.st_Bottom.Name = "st_Bottom";
            this.st_Bottom.Size = new System.Drawing.Size(784, 22);
            this.st_Bottom.TabIndex = 2;
            this.st_Bottom.Text = "statusStrip";
            // 
            // stlbl_path
            // 
            this.stlbl_path.BackColor = System.Drawing.Color.Transparent;
            this.stlbl_path.Name = "stlbl_path";
            this.stlbl_path.Size = new System.Drawing.Size(41, 17);
            this.stlbl_path.Text = "empty";
            // 
            // ts_sizeMode
            // 
            this.ts_sizeMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_sizeMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_sizeMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerImageToolStripMenuItem,
            this.autoSizeToolStripMenuItem,
            this.strechImageToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.ts_sizeMode.Image = ((System.Drawing.Image)(resources.GetObject("ts_sizeMode.Image")));
            this.ts_sizeMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_sizeMode.Name = "ts_sizeMode";
            this.ts_sizeMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ts_sizeMode.Size = new System.Drawing.Size(29, 20);
            this.ts_sizeMode.Text = "Picturebox size mode";
            this.ts_sizeMode.ToolTipText = "Size modes";
            // 
            // centerImageToolStripMenuItem
            // 
            this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.centerImageToolStripMenuItem.Text = "CenterImage";
            this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
            // 
            // autoSizeToolStripMenuItem
            // 
            this.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            this.autoSizeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.autoSizeToolStripMenuItem.Text = "AutoSize";
            this.autoSizeToolStripMenuItem.Click += new System.EventHandler(this.autoSizeToolStripMenuItem_Click);
            // 
            // strechImageToolStripMenuItem
            // 
            this.strechImageToolStripMenuItem.Name = "strechImageToolStripMenuItem";
            this.strechImageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.strechImageToolStripMenuItem.Text = "StrechImage";
            this.strechImageToolStripMenuItem.Click += new System.EventHandler(this.strechImageToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // ts_Delete
            // 
            this.ts_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Delete.Image = ((System.Drawing.Image)(resources.GetObject("ts_Delete.Image")));
            this.ts_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Delete.Name = "ts_Delete";
            this.ts_Delete.Size = new System.Drawing.Size(29, 20);
            this.ts_Delete.Text = "Delete";
            // 
            // ts_Rotate_left
            // 
            this.ts_Rotate_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Rotate_left.Image = global::SimpleImageViewer.Properties.Resources.arrow_rotate_anticlockwise;
            this.ts_Rotate_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Rotate_left.Name = "ts_Rotate_left";
            this.ts_Rotate_left.Size = new System.Drawing.Size(29, 20);
            this.ts_Rotate_left.Text = "Delete";
            this.ts_Rotate_left.Click += new System.EventHandler(this.ts_Rotate_left_Click);
            // 
            // pb_mainView
            // 
            this.pb_mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_mainView.Location = new System.Drawing.Point(0, 24);
            this.pb_mainView.Name = "pb_mainView";
            this.pb_mainView.Size = new System.Drawing.Size(784, 515);
            this.pb_mainView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_mainView.TabIndex = 3;
            this.pb_mainView.TabStop = false;
            this.pb_mainView.DragDrop += new System.Windows.Forms.DragEventHandler(this.pb_mainView_DragDrop);
            this.pb_mainView.DragEnter += new System.Windows.Forms.DragEventHandler(this.pb_mainView_DragEnter);
            this.pb_mainView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_mainView_MouseDown);
            // 
            // mainFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pb_mainView);
            this.Controls.Add(this.st_Bottom);
            this.Controls.Add(this.mnu_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Main;
            this.Name = "mainFrm";
            this.Text = "SimpleImageViewer";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.st_Bottom.ResumeLayout(false);
            this.st_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip st_Bottom;
        public System.Windows.Forms.ToolStripStatusLabel stlbl_path;
        private System.Windows.Forms.PictureBox pb_mainView;
        private System.Windows.Forms.ToolStripDropDownButton ts_sizeMode;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strechImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ts_Delete;
        private System.Windows.Forms.ToolStripDropDownButton ts_Rotate_left;
    }
}

