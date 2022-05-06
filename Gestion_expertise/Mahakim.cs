using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_expertise
{
    public partial class Mahakim : UserControl
    {
        public Mahakim()
        {
            InitializeComponent();
        }
        private void Mahakim_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://mahakim.ma/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

    }
}
