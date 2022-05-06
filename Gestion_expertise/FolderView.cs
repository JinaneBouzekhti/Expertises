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
    public partial class FolderView : UserControl
    {
        public FolderView()
        {
            InitializeComponent();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

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
