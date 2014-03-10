using System;
using System.Windows.Forms;

namespace BrowserContainer
{
    public partial class FormMain : Form
    {
        public string TargetUrl
        {
            get;
            set;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TargetUrl))
            {
                webBrowser1.Navigate(TargetUrl);
            }
        }
    }
}
