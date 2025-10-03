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
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                var esporte_modalidade = textModalidade.Text;
                var valor_modalidade = textValor.Text;

                //Adicionando código de inserção

                string sql = "INSERT INTO Modalidade (Nome, Valor) VALUES (@nome, @valor)";
                using (var cmd=new MySqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@nome", esporte_modalidade);
                    cmd.Parameters.AddWithValue("@valor", valor_modalidade);
                    cmd.ExecuteNonQuery();
                }
                //Mensagem

                MessageBox.Show("Modalidade cadastrada com sucesso!");
            }
        }
    }
}