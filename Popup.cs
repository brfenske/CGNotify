using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CGNotify
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            Screen rightmost = Screen.AllScreens[0];
            this.Left = rightmost.WorkingArea.Right - this.Width;
            Program.Taskbar taskBar = new Program.Taskbar();
            this.Top = taskBar.Location.Y + this.Height + 5;
            this.Top = rightmost.WorkingArea.Bottom - taskBar.Location.Y - this.Height;
            this.Left = taskBar.Location.X - this.Width - 5;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.White, Color.AliceBlue, LinearGradientMode.Vertical);
            g.FillRectangle(brush, rect);
        }

        private void btnHide_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
        }

        private void btnLaunchBrowserContainer_Click(object sender, System.EventArgs e)
        {
            Process.Start("IExplore.exe", "www.google.com");
            this.Visible = false;
        }
    }
}
