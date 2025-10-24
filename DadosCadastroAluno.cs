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
    public partial class DadosCadastroAluno : Form
    {
        public DadosCadastroAluno()
        {
            InitializeComponent();
        }

        private void dataCalendarioPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DadosCadastroAluno_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
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

                    MessageBox.Show("Registros carregados: " + dt.Rows.Count);
                    dataCalendarioPesquisa.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_BuscarCadastroAluno_Click(object sender, EventArgs e)
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
                        if (!string.IsNullOrWhiteSpace(txtIdPlano.Text))
                        {
                            query += " WHERE id_plano = @id_plano";
                        }

                        MySqlCommand cmd = new MySqlCommand(query, con);

                        if (!string.IsNullOrWhiteSpace(txtIdPlano.Text))
                            cmd.Parameters.AddWithValue("@id_plano", txtIdPlano.Text);

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
