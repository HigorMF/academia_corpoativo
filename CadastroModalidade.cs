using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public partial class CadastroModalidade : Form
    {
        public CadastroModalidade()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Validação simples para evitar  campos em branco
            if (string.IsNullOrWhiteSpace(textModalidade.Text) || string.IsNullOrWhiteSpace(textValor.Text))

            {
                MessageBox.Show("Preencha todos os campos!");
            }
            //Validação e conversão do valor
            if (!Decimal.TryParse(textValor.Text, out decimal valor_modalidade))
            {
                MessageBox.Show("Digite um valor válido para o campo Valor!");
                return;
            }

            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                conn.Open(); //Abrir conexão

                string sql = "INSERT INTO modalidade (esporte_modalidade, valor_modalidade) VALUES (@esporte_modalidade, @valor_modalidade)";
                using (var cmd = new MySqlCommand(sql, conn))

                {
                    cmd.Parameters.AddWithValue("@esporte_modalidade", textModalidade.Text.Trim());
                    cmd.Parameters.AddWithValue("@valor_modalidade", valor_modalidade);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Modalidade cadastrada com sucesso!");
            }
        }
    }

}   
               
