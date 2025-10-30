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

          
        }

        private void CalendarioGeral_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayCalendar_DateChanged()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            ano = now.Year;

            static_mes = mes.ToString();
            static_ano = ano.ToString();

            AtualizarCalendario();

            CalendarioGeral.Invalidate();
            CalendarioGeral.Update();
            this.Refresh();


            /*string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
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
                cdDias.displayInformacao();
                CalendarioGeral.Controls.Add(cdDias);
            }*/

        }

        private void btProximo_Click(object sender, EventArgs e)
        {

            mes++;
            if (mes > 12)
            {
                mes = 1;
                ano++;
            }

            static_mes = mes.ToString();
            static_ano = ano.ToString();

            AtualizarCalendario();


            /*CalendarioGeral.Controls.Clear();

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
                cdDias.displayInformacao();
                CalendarioGeral.Controls.Add(cdDias);
            }*/
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            mes--;
            if (mes < 1)
            {
                mes = 12;
                ano--;
            }

            static_mes = mes.ToString();
            static_ano = ano.ToString();

            AtualizarCalendario();

            /*CalendarioGeral.Controls.Clear();

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
                cdDias.displayInformacao();
                CalendarioGeral.Controls.Add(cdDias);
            }*/
        }

        private void AtualizarCalendario()
        {
            CalendarioGeral.Controls.Clear();

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = $"{monthname} {ano}";

            DateTime startOfMonth = new DateTime(ano, mes, 1);
            int daysInMonth = DateTime.DaysInMonth(ano, mes);
            int startDayOfWeek = (int)startOfMonth.DayOfWeek;

            for (int i = 0; i < startDayOfWeek; i++)
            {
                ControleDeUso cdUso = new ControleDeUso();
                CalendarioGeral.Controls.Add(cdUso);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                ControleDeDias1 cdDias = new ControleDeDias1();
                cdDias.Days(i);
                cdDias.displayInformacao(); // agora usa o mês/ano corretos
                CalendarioGeral.Controls.Add(cdDias);
            }
            CalendarioGeral.Invalidate();
            CalendarioGeral.Update();
            this.Refresh();
        }
    }
}
