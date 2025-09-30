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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            var nome = txtNomeCompleto.Text.Trim();
            var cpf = txtCPF.Text.Trim();
            var email = txtEmail.Text.Trim();
            var telefone = txtTelefone.Text.Trim();
            var senha = txtSenha.Text.Trim();

            // --- Validações ---
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("⚠️ Todos os campos devem ser preenchidos.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o nome tem pelo menos duas palavras (nome + sobrenome)
            if (!nome.Contains(" "))
            {
                MessageBox.Show("⚠️ Digite o nome completo (com sobrenome).",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexao conexao = new Conexao();
                using (var conn = conexao.GetConnection())
                {
                    string comando =
                        "INSERT INTO cadastro_login (nome, cpf, email, telefone, senha, tipo_login) " +
                        "VALUES (@nome, @cpf, @email, @telefone, @senha, @tipo_login)";

                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        cmd.Parameters.AddWithValue("@tipo_login", "Professor");

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("✅ Cadastro realizado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("❌ Erro no banco de dados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro inesperado: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
