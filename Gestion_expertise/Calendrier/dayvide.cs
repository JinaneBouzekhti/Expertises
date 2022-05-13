using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_expertise.Calandrier
{
    public partial class dayvide : UserControl
    {
        public dayvide()
        {
            InitializeComponent();
        }

        private void dayvide_Load(object sender, EventArgs e)
        {

        }
        public void daynum(int day)
        {
            numdaylab.Text = day.ToString("00");
        }
    }
}
