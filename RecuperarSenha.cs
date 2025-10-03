using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia_corpoativo
{
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool SenhaValida(string senha)
        {
            if (senha.Length < 8) return false;
            if (!Regex.IsMatch(senha, "[A-Z]")) return false;
            if (!Regex.IsMatch(senha, "[^a-zA-Z0-9]")) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailAtual = txtEmailAtual.Text.Trim();
            string novoEmail = txtNovoEmail.Text.Trim();
            string confirmaEmail = txtRepetirNovoEmail.Text.Trim();
            string novaSenha = txtNovaSenha.Text.Trim();
            string confirmaSenha = txtConfirmacaoNovaSenha.Text.Trim();

            // 1) Validações básicas
            if (string.IsNullOrEmpty(emailAtual) || string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Informe o e-mail atual e a nova senha.");
                return;
            }

            if (!string.IsNullOrEmpty(novoEmail) && novoEmail != confirmaEmail)
            {
                MessageBox.Show("Os e-mails não conferem.");
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não conferem.");
                return;
            }

            if (!SenhaValida(novaSenha))
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres, " +
                                "contendo pelo menos uma letra maiúscula e um caractere especial.");
                return;
            }

            // 2) Atualiza no banco
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                conn.Open();

                string comando = "";

                if (!string.IsNullOrEmpty(novoEmail))
                {
                    comando = "UPDATE cadastro_login SET email = @novoEmail, senha = @novaSenha WHERE email = @emailAtual";
                }
                else
                {
                    comando = "UPDATE cadastro_login SET senha = @novaSenha WHERE email = @emailAtual";
                }

                using (var cmd = new MySqlCommand(comando, conn))
                {
                    cmd.Parameters.AddWithValue("@emailAtual", emailAtual);
                    cmd.Parameters.AddWithValue("@novaSenha", novaSenha);

                    if (!string.IsNullOrEmpty(novoEmail))
                        cmd.Parameters.AddWithValue("@novoEmail", novoEmail);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Senha redefinida com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("E-mail não encontrado.");
                    }



                }
            }
        }

        private void checkNovaSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = !checkNovaSenha.Checked;

        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = true;
        }

        private void txtConfirmacaoNovaSenha_TextChanged(object sender, EventArgs e)
        {
            txtConfirmacaoNovaSenha.UseSystemPasswordChar = true;
        }
        

        private void checkConfirmarNovaSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmacaoNovaSenha.UseSystemPasswordChar = !checkConfirmarNovaSenha.Checked;
        }
    
    }
}
