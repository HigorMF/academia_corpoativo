using MySql.Data.MySqlClient;
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
    public partial class Aluno : Form
    {
        public Aluno(string nome, string matricula, string plano)
        {
            InitializeComponent();

            lbNome.Text = $"Aluno: {nome}";
            lbNumeroMatricula.Text = $"Matrícula: {matricula}";
            label2.Text = $"Plano: {plano}";
        }


        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbNumeroMatricula_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            Frequencia frequencia = new Frequencia();
            frequencia.Show();
        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new Conexao().GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM pagamento";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void CarregarPlano()
        {
            {
                {
                    try
                    {
                        using (MySqlConnection con = new Conexao().GetConnection())
                        {
                            con.Open();

                            string query = @"SELECT id_pagamento, id_plano, data_pagamento, valor, forma_pagamento, status_pagamento 
                             FROM pagamento";

                            // Se o campo tiver algo digitado, filtra
                            if (!string.IsNullOrWhiteSpace(btnBuscar.Text))
                            {
                                query += " WHERE id_plano = @id_plano";
                            }

                            MySqlCommand cmd = new MySqlCommand(query, con);

                            if (!string.IsNullOrWhiteSpace(btnBuscar.Text))
                                cmd.Parameters.AddWithValue("@id_plano", btnBuscar.Text);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataCalendarioPesquisa.DataSource = dt;

                            if (dt.Rows.Count == 0)
                                MessageBox.Show("Nenhum registro encontrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar dados: " + ex.Message);
                    }
                }
            }
        }
    }
}
