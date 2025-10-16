using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia_corpoativo
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            displayCalendar_DateChanged();
        }

        private void displayCalendar_DateChanged()
        {
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

            int days = DateTime.DaysInMonth(now.Year, now.Month);



            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 2;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ControleDeUso ucblack = new ControleDeUso();
                CalendarioGeral.Controls.Add(ucblack);
            }

            for (int i = 1; i <= days; i++)
            {
                ControleDeDias1 ucdays = new ControleDeDias1();
                ucdays.Days(i);
                CalendarioGeral.Controls.Add(ucdays);

            }
        }

        private void CalendarioGeral_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
