using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyboardSith
{
  public partial class MainForm : Form
  {
    private const string DisabledText = "Press CTRL+SHIFT+ALT+F11 to capture the mouse.";
    private const string EnabledText = "Press CTRL+SHIFT+ALT+F11 to release the mouse.";
    private const string DisableNotificationText = "Disable Sith Code Notification";
    private const string EnableNotificationText = "Enable Sith Code Notification";
    private const string SithCode = "Sith Code:";

    private static readonly string SithCodeText =
      "Peace is a lie; there is only passion." + Environment.NewLine +
      "Through passion, I gain strength." + Environment.NewLine +
      "Through strength, I gain power." + Environment.NewLine +
      "Through power, I gain victory." + Environment.NewLine +
      "Through victory, my chains are broken." + Environment.NewLine +
      "The Keyboard shall free me.";

    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    private const int WM_HOTKEY = 0x0312;


    private bool captureEnabled;
    private bool codeNotificationEnabled;

    public MainForm()
    {
      InitializeComponent();
      Opacity = 0.7f;
      ModifierKeys modifer = KeyboardSith.ModifierKeys.Control | KeyboardSith.ModifierKeys.Shift |
                             KeyboardSith.ModifierKeys.Alt;
      Keys key = Keys.F11;
      RegisterHotKey(Handle, 0, (uint)modifer, (uint)key);
      captureEnabled = true;
      codeNotificationEnabled = true;
      ToggleEnabled();
    }

    protected override void WndProc(ref Message m)
    {
      base.WndProc(ref m);

      if (m.Msg == WM_HOTKEY)
      {
        ToggleEnabled();
      }
    }

    private void ToggleEnabled()
    {
      captureEnabled = !captureEnabled;
      SetContextMenuState();
      SetNotifyIcon();
      SetLabelText();
    }

    private void SetContextMenuState()
    {
      captureMouseToolStripMenuItem.Enabled = !captureEnabled;
      releaseMouseToolStripMenuItem.Enabled = captureEnabled;
    }

    private void SetLabelText()
    {
      label1.Text = captureEnabled ? EnabledText : DisabledText;
    }

    private void SetNotifyIcon()
    {
      notifyIcon1.Icon = captureEnabled ? Properties.Resources.RedLightSaber : Properties.Resources.BlueLightSaber;
      if (!captureEnabled && codeNotificationEnabled)
      {
        notifyIcon1.ShowBalloonTip(5000, SithCode, SithCodeText, ToolTipIcon.Warning);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (!captureEnabled) { return; }
      int newX = Cursor.Position.X;
      int newY = Cursor.Position.Y;

      if (Cursor.Position.X < Location.X)
      {
        newX = Location.X;
      }
      else if (Cursor.Position.X > Location.X + Width)
      {
        newX = Location.X + Width;
      }

      if (Cursor.Position.Y < Location.Y)
      {
        newY = Location.Y;
      }
      else if (Cursor.Position.Y > Location.Y + Height)
      {
        newY = Location.Y + Height;
      }

      Cursor.Position = new Point(newX, newY);
    }

    private void ToolStripMenuItemClick(object sender, EventArgs e)
    {
      ToggleEnabled();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void disableToolStripMenuItem_Click(object sender, EventArgs e)
    {
      codeNotificationEnabled = !codeNotificationEnabled;
      disableNotificationToolStripMenuItem.Text = codeNotificationEnabled
                                                    ? DisableNotificationText
                                                    : EnableNotificationText;
    }
  }
}
