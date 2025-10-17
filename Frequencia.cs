using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public partial class Frequencia : Form
    {
        public Frequencia()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                var ID_Aluno = txtID_Aluno.Text;
                var ID_Turma = txtID_Turma.Text;
                var Data = mtbData.Text;
                var Entrada = mtbEntrada.Text;
                var Saida = mtbSaida.Text;

                string Sql = "INSERT INTO frequencia (id_aluno, id_turma, data, entrada, saida) VALUES(@id_aluno, @id_turma, @data, @entrada, @saida)";
                using (var cmd = new MySqlCommand(Sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_aluno", ID_Aluno);
                    cmd.Parameters.AddWithValue("@id_turma", ID_Turma);
                    cmd.Parameters.AddWithValue("@data", Data);
                    cmd.Parameters.AddWithValue("@entrada", Entrada);
                    cmd.Parameters.AddWithValue("@saida", Saida);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)

                            MessageBox.Show("Frequencia cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        else
                            MessageBox.Show("Nenhum registro foi inserido. Verifique os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Erro ao inserir dados no banco de dados:+ ex.Message", "Erro de banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
        }
    }
}