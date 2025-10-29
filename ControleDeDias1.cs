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
          
            string diaFormatado = lblDia.Text.PadLeft(2, '0');
            string dataCompleta = $"{Calendario.static_ano}-{Calendario.static_mes}-{diaFormatado}";

            string sql = "SELECT id_agendamento, data_agendada, sobre FROM agendamento WHERE data_agendada = '2025-10-07'";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@data_agendada", dataCompleta);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (dataCompleta.StartsWith("2025-10-07"))
                            {
                                lblInformacao.Text = $"{reader["sobre"]}";
                                lblInformacao.Refresh();
                            }

                        }
                        else
                        {
                            lblInformacao.Text = "Nenhum agendamento para este dia.";
                            lblInformacao.Refresh();
                        }

                    }
                }
            }

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

        public void displayInformacao()
        {


            string diaFormatado = lblDia.Text.PadLeft(2, '0');
            string dataCompleta = $"{Calendario.static_ano} - {Calendario.static_mes} - {diaFormatado}";

            string sql = "SELECT id_agendamento, data_agendada, sobre FROM agendamento WHERE data_agendada = '2025-10-07'";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
               
                
                
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@data_agendada", dataCompleta);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblInformacao.Text = $"{reader["data_agendada"]}\n{reader["sobre"]}";
                            lblInformacao.Refresh();
                             
                        }
                        else
                        {
                            lblInformacao.Text = "Nenhum agendamento para este dia.";
                            lblInformacao.Refresh();
                        }
                        lblInformacao.Enabled = true;
                        lblInformacao.Text = "juhjg";
                        lblInformacao.ForeColor = Color.Black;
                        lblInformacao.AutoSize = true;
                        this.AutoSize = true;
                        lblInformacao.Refresh();

                    }
                }
            }

        }

        public void days(int numDia)
        {
            lblDia.Text = numDia.ToString();
            //static_dia = numDia.ToString();
            displayInformacao(); // Inicia a consulta ao banco de dados.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayInformacao();
        }


        private void lblInformacao_Click(object sender, EventArgs e)
        {

        }
    }
}


