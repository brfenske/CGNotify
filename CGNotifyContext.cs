using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Reflection;

namespace CGNotify
{
    public class CGNotifyContext : ApplicationContext
    {
        private NotifyIcon notifyIcon;
        private ContextMenuStrip trayIconContextMenu;
        private ToolStripMenuItem closeMenuItem;
        private Popup message = new Popup();

        private readonly HostManager hostManager;

        private System.ComponentModel.IContainer components;	// a list of components to dispose when the context is disposed
        
        public CGNotifyContext()
        {
            InitializeContext();
            hostManager = new HostManager(notifyIcon);
           // hostManager.BuildServerAssociations();
            if (!hostManager.IsDecorated)
            {
                //ShowIntroForm();
            }
        }

        private void InitializeContext()
        {
            components = new System.ComponentModel.Container();
            notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Properties.Resources.Inactive,
                Text = "CG Notify",
                Visible = true
            };
            notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            notifyIcon.MouseUp += notifyIcon_MouseUp;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            //ShowIntroForm();
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(notifyIcon, null);
            }
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            //hostManager.BuildServerAssociations();
            //hostManager.BuildContextMenu(notifyIcon.ContextMenuStrip);
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            //notifyIcon.ContextMenuStrip.Items.Add(hostManager.ToolStripMenuItemWithHandler("Show &Details", showDetailsItem_Click));
            //notifyIcon.ContextMenuStrip.Items.Add(hostManager.ToolStripMenuItemWithHandler("&Help/About", showHelpItem_Click));
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            notifyIcon.ContextMenuStrip.Items.Add(hostManager.ToolStripMenuItemWithHandler("&Exit", exitItem_Click));
        }

     

        private void InitializeComponent()
        {
            notifyIcon = new NotifyIcon();

            //trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            //trayIcon.BalloonTipText = "1 Survey ready";
            //trayIcon.BalloonTipTitle = "CG Notify";
            //trayIcon.Text = "1 Survey ready";
            notifyIcon.Icon = Properties.Resources.Inactive;
            notifyIcon.Click += TrayIcon_Click;
            trayIconContextMenu = new ContextMenuStrip();
            closeMenuItem = new ToolStripMenuItem();
            trayIconContextMenu.SuspendLayout();

            // TrayIconContextMenu
            this.trayIconContextMenu.Items.AddRange(new ToolStripItem[] { this.closeMenuItem });
            this.trayIconContextMenu.Name = "TrayIconContextMenu";
            this.trayIconContextMenu.Size = new Size(153, 70);

            // CloseMenuItem
            this.closeMenuItem.Name = "CloseMenuItem";
            this.closeMenuItem.Size = new Size(152, 22);
            this.closeMenuItem.Text = "Exit CGNotify";
            this.closeMenuItem.Click += new EventHandler(this.CloseMenuItem_Click);

            trayIconContextMenu.ResumeLayout(false);
            notifyIcon.ContextMenuStrip = trayIconContextMenu;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
        }

        //private void TrayIcon_Click(object sender, EventArgs e)
        //{
        //    //Here you can do stuff if the tray icon is Clicked
        //    FormMain frm = new FormMain();
        //    frm.Show();
        //}

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            notifyIcon.Icon = Properties.Resources.Led;
            message.ShowDialog();
            notifyIcon.Icon = Properties.Resources.Inactive;
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit CGNotify?", "CGNotify", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}