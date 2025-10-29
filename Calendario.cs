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

namespace academia_corpoativo
{
    public partial class Calendario : Form
    {
        int mes, ano;

        public static string static_mes, static_ano;

        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            displayCalendar_DateChanged();
            ControleDeDias1 dias = new ControleDeDias1();
          
            dias.displayInformacao();
            dias.Show();
            dias.BringToFront();
            dias.Visible = true;
            
        }

        private void CalendarioGeral_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayCalendar_DateChanged()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            ano = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = monthname + " " + ano;

            static_mes = mes.ToString();
            static_ano = ano.ToString();

            DateTime startofthemonth = new DateTime(ano, mes, 1);

            int days = DateTime.DaysInMonth(ano, mes);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ControleDeUso cdUso = new ControleDeUso();
                CalendarioGeral.Controls.Add(cdUso);
            }

            for (int i = 1; i <= days; i++)
            {
                ControleDeDias1 cdDias = new ControleDeDias1();
                cdDias.Days(i);
                CalendarioGeral.Controls.Add(cdDias);
            }
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            CalendarioGeral.Controls.Clear();

            mes++;

            static_mes = mes.ToString();
            static_ano = ano.ToString();

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = monthname + " " + ano;

            DateTime now = DateTime.Now;

             DateTime startofthemonth = new DateTime(ano, mes, 1);

            int days = DateTime.DaysInMonth(ano, mes);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ControleDeUso cdUso = new ControleDeUso();
                CalendarioGeral.Controls.Add(cdUso);
            }

            for (int i = 1; i <= days; i++)
            {
                ControleDeDias1 cdDias = new ControleDeDias1();
                cdDias.Days(i);
                CalendarioGeral.Controls.Add(cdDias);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CalendarioGeral.Controls.Clear();

            mes--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = monthname + " " + ano;

            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(ano, mes, 1);

            int days = DateTime.DaysInMonth(ano, mes);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ControleDeUso cdUso = new ControleDeUso();
                CalendarioGeral.Controls.Add(cdUso);
            }

            for (int i = 1; i <= days; i++)
            {
                ControleDeDias1 cdDias = new ControleDeDias1();
                cdDias.Days(i);
                CalendarioGeral.Controls.Add(cdDias);
            }
        }
    }
}
