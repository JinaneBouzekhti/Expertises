using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;
namespace Gestion_expertise
{
    public partial class suivi_expertise : UserControl
    {
        public suivi_expertise()
        {
            InitializeComponent();
        }

        private void suivi_expertise_Load(object sender, EventArgs e)
        {
           
        }
        
        private void TextBox_Enter(object sender, EventArgs e)
        {
            RJTextBox tb = null;
            if (sender is RJTextBox)
            {
                tb = (RJTextBox)sender;
                tb.UnderlinedStyle = true;
            }
     
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            RJTextBox tb = null;
            if (sender is RJTextBox)
            {
                tb = (RJTextBox)sender;
                tb.UnderlinedStyle = false;
            }
        }
    }
}
