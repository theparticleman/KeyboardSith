namespace KeyboardSith
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.captureMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.releaseMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.disableNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label1
      // 
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label1.Location = new System.Drawing.Point(19, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(173, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Press CTRL+SHIFT+ALT+F12 to capture the mouse";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Text = "Keyboard Sith";
      this.notifyIcon1.Visible = true;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureMouseToolStripMenuItem,
            this.releaseMouseToolStripMenuItem,
            this.toolStripSeparator1,
            this.disableNotificationToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(233, 126);
      // 
      // captureMouseToolStripMenuItem
      // 
      this.captureMouseToolStripMenuItem.Name = "captureMouseToolStripMenuItem";
      this.captureMouseToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.captureMouseToolStripMenuItem.Text = "Capture Mouse";
      this.captureMouseToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemClick);
      // 
      // releaseMouseToolStripMenuItem
      // 
      this.releaseMouseToolStripMenuItem.Name = "releaseMouseToolStripMenuItem";
      this.releaseMouseToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.releaseMouseToolStripMenuItem.Text = "Release Mouse";
      this.releaseMouseToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemClick);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // disableNotificationToolStripMenuItem
      // 
      this.disableNotificationToolStripMenuItem.Name = "disableNotificationToolStripMenuItem";
      this.disableNotificationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
      this.disableNotificationToolStripMenuItem.Text = "Disable Sith Code Notification";
      this.disableNotificationToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(204, 48);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "Keyboard Sith";
      this.TopMost = true;
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem captureMouseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem releaseMouseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disableNotificationToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  }
}

