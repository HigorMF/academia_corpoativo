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
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int IdPlano;
            DateTime DataPagamento;
            decimal Valor;
            string FormaPagamento = cmbFormaPagamento.Text;
            string StatusPagamento = cmbStatusPagamento.Text;

            //Validação dos campos
            if (!int.TryParse(txtIDPlano.Text, out IdPlano))
            {
                MessageBox.Show("Informe um ID de plano válido (número inteiro).");
                return;
            }

            if (!DateTime.TryParse(mtbDataPagamento.Text, out DataPagamento))
            {
                MessageBox.Show("Informe uma data válida.");
                return;
            }

            if (!decimal.TryParse(txtValor.Text, out Valor))
            {
                MessageBox.Show("Informe um valor numérico válido.");
                return;
            }
            //Conexão ao banco
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                string sql = @"INSERT INTO Pagamento
                    (IdPlano, DataPagamento, Valor, FormaPagamento, StatusPagamento);
                VALUES(IdPlano, DataPagamento, Valor, FormaPagamento, StatusPagamento);";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    //Definir os parametros
                    cmd.Parameters.AddWithValue("@IdPlano", IdPlano);
                    cmd.Parameters.AddWithValue("@DataPagamento", DataPagamento);
                    cmd.Parameters.AddWithValue("@Valor", Valor);
                    cmd.Parameters.AddWithValue("@FormaPagamento", FormaPagamento);
                    cmd.Parameters.AddWithValue("@StatusPagamento", StatusPagamento);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pagamento salvo com sucesso!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erro ao salvar pagamento:{ex.Message}");
                    }
                }
            }

        }
    }
}