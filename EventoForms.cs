using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public partial class EventoForms : Form
    {
        String connString = "server=10.37.44.29; user id = root; password=root;database=corpo_ativo";

        public EventoForms()
        {
            InitializeComponent();
            CarregarProfessores();
        
        }

        private void EventoForms_Load(object sender, EventArgs e)
        {
            txtData.Text = Calendario.static_ano + "/" + Calendario.static_mes + "/" + ControleDeDias1.static_dia;
        }


        private void btoSalvar_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO agendamento (data_agendada, sobre) VALUES (@data_agendada, @sobre)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data_agendada", txtData.Text);
            cmd.Parameters.AddWithValue("@sobre", txtHorario.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Evento salvo com sucesso!");
            conn.Dispose();
            conn.Close();
        }

        private void CarregarProfessores()
        {
            // SUA CONEXÃO COM O BANCO
            string conexaoString = "server=10.37.44.29; user id = root; password=root;database=corpo_ativo;";

            using (MySqlConnection conn = new MySqlConnection(conexaoString))
            {
                try
                {
                    conn.Open();

                    // QUERY PARA PEGAR SOMENTE OS PROFESSORES
                    string query = "SELECT nome FROM cadastro_Login WHERE tipo_login = 'Professor'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cboProfessores.Items.Clear(); // Limpa antes de preencher

                        while (reader.Read())
                        {
                            string nomeProfessor = reader.GetString("nome");
                            cboProfessores.Items.Add(nomeProfessor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar professores: " + ex.Message);
                }
            }


        }
    }
}
