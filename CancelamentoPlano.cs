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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace academia_corpoativo
{
    public partial class CancelamentoPlano : Form
    {
        public CancelamentoPlano()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelamento_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string confirmarEmail = txtConfirmaçãoEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string confirmarSenha = txtConfirmarSenha.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(confirmarEmail) ||
                string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (email != confirmarEmail)
            {
                MessageBox.Show("Os e-mails não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Conexao conexao = new Conexao();
                using (var conn = conexao.GetConnection())
                {
                    conn.Open();
                    string id_cadastro_login = null;
                    string queryLogin = "SELECT email, senha, id_cadastro_login FROM cadastro_login WHERE email = @email AND senha = @senha";
                    string cadastro_login = null;
                    


                    using (var cmd = new MySqlCommand(queryLogin, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                            return;
                        }

                       cadastro_login  = result.ToString();
                    }

                    // 3️⃣ Confirmação
                    DialogResult confirmar = MessageBox.Show(
                        "Tem certeza que deseja cancelar e excluir todos os dados do seu plano? Essa ação é permanente.",
                        "Confirmação de Cancelamento",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmar == DialogResult.No)
                        return;

                    // 4️⃣ Transação com exclusão em cascata
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            // Frequência
                            using (var cmd = new MySqlCommand("DELETE FROM frequencia WHERE id_cadastro_login = @id_cadastro_login", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                                cmd.ExecuteNonQuery();
                            }

                            // AcessoAlunoPlano
                            using (var cmd = new MySqlCommand("DELETE FROM acessoalunoplano WHERE id_cadastro_login = @id_cadastro_login", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                                cmd.ExecuteNonQuery();
                            }

                            // Curso livre
                                using (var cmd = new MySqlCommand("DELETE FROM curso_livre WHERE id_cadastro_login = @id_cadastro_login", conn, tran))
                                {
                                cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                                cmd.ExecuteNonQuery();
                            }

                            // Turma
                            using (var cmd = new MySqlCommand("DELETE FROM turma WHERE id_cadastro_login = @id_cadastro_login", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                                cmd.ExecuteNonQuery();
                            }

                            // Matricula
                            using (var cmd = new MySqlCommand("DELETE FROM matricula WHERE id_cadastro_login = @id_cadastro_login", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                                cmd.ExecuteNonQuery();
                            }

                            // Plano
                            using (var cmd = new MySqlCommand("DELETE FROM plano WHERE id_cadastro_login = @id_cadastro_login", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@id_cadastro_login", id_cadastro_login);
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                            MessageBox.Show("Plano cancelado e todos os dados relacionados foram excluídos com sucesso. Seu login permanece ativo.");
                        }
                        catch (MySqlException ex)
                        {
                            tran.Rollback();
                            MessageBox.Show($"Erro MySQL ({ex.Number}): {ex.Message}", "Erro no Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Erro ao cancelar o plano: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
