using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public partial class ControleDeDias1 : UserControl
    {

        String connString = "server=10.37.44.29; user id = root; password=root;database=corpo_ativo";

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
            timer1.Start();

            EventoForms eventoForm = new EventoForms();
            eventoForm.Show();
        }

        private void displayInformacao()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM tbl_calendar where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@data_agendada", Calendario.static_ano + "/" + Calendario.static_mes + "/");
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblInformacao.Text = reader["evento"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayInformacao();
        }
    }
}
