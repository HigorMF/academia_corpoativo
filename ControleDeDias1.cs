using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia_corpoativo
{
    public partial class ControleDeDias1 : UserControl
    {
        public static int static_dia;
        public ControleDeDias1()
        {
            InitializeComponent();
        }

        private void ControleDeDias1_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numday)
        {
            lblDia.Text = numday + "";
        }

        private void ControleDeDias1_Click(object sender, EventArgs e)
        {
            static_dia = Convert.ToInt32(lblDia.Text);
            EventoForms eventoForm = new EventoForms();
            eventoForm.Show();
        }
    }
}
