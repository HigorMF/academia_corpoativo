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
            int idProfessor = Convert.ToInt32(cboProfessores.SelectedValue);

            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO agendamento (id_cadastro_login, data_agendada, horario_agendado, sobre) VALUES (@id, @data, @hora, @sobre)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", idProfessor);
                    cmd.Parameters.AddWithValue("@data", txtData.Text);
                    cmd.Parameters.AddWithValue("@hora", txtHorario.Text);
                    cmd.Parameters.AddWithValue("@sobre", txtSobre.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Evento salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar evento: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                this.Close();
            }
            
        }

        private void CarregarProfessores()
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_cadastro_login, nome FROM cadastro_login WHERE tipo_login = 'Professor'";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboProfessores.DataSource = dt;
                    cboProfessores.DisplayMember = "nome";       // O que aparece na tela
                    cboProfessores.ValueMember = "id_cadastro_login"; // O valor interno (ID)
                    cboProfessores.SelectedIndex = -1; // Nenhum selecionado inicialmente
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar professores: " + ex.Message);
                }
            }
        }

        
    }
}



