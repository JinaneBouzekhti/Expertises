using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_expertise.Calandrier
{
    public partial class Clandrier : Form
    {
        public Clandrier()
        {
            InitializeComponent();
        }

        int month, year;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DisplayDays(month, year);
            yearmonth.Text = Convert.ToDateTime(new DateTime(year, month, 1)).ToString("MMMM, yyyy",new CultureInfo("fr-FR"));
        }
        public void DisplayDays(int _month, int _year)
        {
            container.Controls.Clear();

            DateTime startofmonth = new DateTime(_year, _month, 1);
            int days = DateTime.DaysInMonth(_year, _month);
            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayoftheweek; i++)
            {
                dayvide d = new dayvide();
                d.daynum(DateTime.DaysInMonth(_year, _month - 1) - dayoftheweek + i);
                container.Controls.Add(d);
            }

            for (int i = 1; i <= days; i++)
            {
                daypanel d = new daypanel();
                d.daynum(i);
                if (i == DateTime.Now.Day && _month == DateTime.Today.Month && _year == DateTime.Today.Year)
                    d.BackColor = Color.FromArgb(255, 242, 224);
                d.getactivite(_year, _month, i);
                container.Controls.Add(d);
            }

            for (int i = 1; i <= 42 - dayoftheweek + days; i++)
            {
                dayvide d = new dayvide();
                d.daynum(i);
                container.Controls.Add(d);
            }
            yearmonth.Text = Convert.ToDateTime(new DateTime(year, month, 1)).ToString("MMMM, yyyy");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (month != 12)
                month++;
            else
            {
                month = 1;
                year++;
            }
            DisplayDays(month, year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (month != 1)
                month--;
            else
            {
                month = 12;
                year--;
            }
            DisplayDays(month, year);
        }


    }
}
