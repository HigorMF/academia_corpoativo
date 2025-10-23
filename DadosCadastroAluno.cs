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
            {
                Conexao conexao = new Conexao();
                string query = @"SELECT id_pagamento, id_plano, data_pagamento, valor, forma_pagamento, status_pagamento FROM pagamento";
                using (MySqlConnection con = conexao.GetConnection())
                {
                    try
                    {
                        con.Open();

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataCalendarioPesquisa.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar aluno: " + ex.Message);
                    }
                }
            }
        }
    }
}
