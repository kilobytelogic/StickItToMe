namespace StickItToMe
{
    partial class Pad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pad));
            this.tb = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resizeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTabAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openClosedTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.cmNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.Khaki;
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.ContextMenuStrip = this.contextMenuStrip;
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Margin = new System.Windows.Forms.Padding(30);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(300, 300);
            this.tb.TabIndex = 0;
            this.tb.Text = "";
            this.tb.SelectionChanged += new System.EventHandler(this.tb_SelectionChanged);
            this.tb.Click += new System.EventHandler(this.tb_Click);
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb.MouseHover += new System.EventHandler(this.tb_MouseHover);
            this.tb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeTabToolStripMenuItem,
            this.moveTabToolStripMenuItem,
            this.deleteTabToolStripMenuItem,
            this.changeTabAppearanceToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.openClosedTabsToolStripMenuItem,
            this.closeTabToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(204, 158);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // resizeTabToolStripMenuItem
            // 
            this.resizeTabToolStripMenuItem.Name = "resizeTabToolStripMenuItem";
            this.resizeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resizeTabToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resizeTabToolStripMenuItem.Text = "Resize Tab";
            this.resizeTabToolStripMenuItem.Click += new System.EventHandler(this.resizeTabToolStripMenuItem_Click);
            // 
            // moveTabToolStripMenuItem
            // 
            this.moveTabToolStripMenuItem.Name = "moveTabToolStripMenuItem";
            this.moveTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.moveTabToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.moveTabToolStripMenuItem.Text = "Move Tab";
            this.moveTabToolStripMenuItem.Click += new System.EventHandler(this.moveTabToolStripMenuItem_Click);
            // 
            // deleteTabToolStripMenuItem
            // 
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.deleteTabToolStripMenuItem.Text = "Delete Tab";
            // 
            // changeTabAppearanceToolStripMenuItem
            // 
            this.changeTabAppearanceToolStripMenuItem.Name = "changeTabAppearanceToolStripMenuItem";
            this.changeTabAppearanceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeTabAppearanceToolStripMenuItem.Text = "Change Tab Appearance";
            this.changeTabAppearanceToolStripMenuItem.Click += new System.EventHandler(this.changeTabAppearanceToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Checked = true;
            this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // openClosedTabsToolStripMenuItem
            // 
            this.openClosedTabsToolStripMenuItem.Name = "openClosedTabsToolStripMenuItem";
            this.openClosedTabsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openClosedTabsToolStripMenuItem.Text = "Open Closed Tabs";
            this.openClosedTabsToolStripMenuItem.Click += new System.EventHandler(this.openClosedTabsToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "StickItToMe";
            this.notifyIcon.ContextMenuStrip = this.cmNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "StickItToMe";
            this.notifyIcon.Visible = true;
            // 
            // cmNotify
            // 
            this.cmNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.cmNotify.Name = "cmNotify";
            this.cmNotify.Size = new System.Drawing.Size(93, 26);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // Pad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ControlBox = false;
            this.Controls.Add(this.tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(100000, 100000);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Pad";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip.ResumeLayout(false);
            this.cmNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem resizeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openClosedTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTabAppearanceToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmNotify;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        public System.Windows.Forms.RichTextBox tb;
    }
}

