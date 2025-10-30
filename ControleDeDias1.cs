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
            displayInformacao();
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
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {

                try
                {
                    string diaFormatado = lblDia.Text.PadLeft(2, '0');
                    string mesFormatado = Calendario.static_mes.PadLeft(2, '0');
                    string dataCompleta = $"{Calendario.static_ano}-{mesFormatado}-{diaFormatado}";

                    string sql = "SELECT sobre FROM agendamento WHERE data_agendada = @data_agendada";

                    
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@data_agendada", dataCompleta);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lblInformacao.Text = 
                                        $"{reader["sobre"]}";

                                    lblInformacao.ForeColor = Color.Black;
                                }
                                else
                                {
                                    lblInformacao.Text = ""; // sem agendamento
                                }
                            }
                        }
                    

                    lblInformacao.Refresh();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro em displayInformacao: " + ex.Message);
                    lblInformacao.Text = "";

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


        
    }
}


