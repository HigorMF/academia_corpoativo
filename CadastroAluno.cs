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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
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
            var planoEscolhido = cboTipoPlano.SelectedItem?.ToString();

            // Validações
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(planoEscolhido))
            {
                MessageBox.Show("⚠️ Todos os campos devem ser preenchidos (incluindo o plano).",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1) Inserir usuário
                            string insertCadastro = @"
                        INSERT INTO cadastro_login (nome, cpf, email, telefone, senha, tipo_login)
                        VALUES (@nome, @cpf, @email, @telefone, @senha, @tipo_login);";
                            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(insertCadastro, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@nome", nome);
                                cmd.Parameters.AddWithValue("@cpf", cpf);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@telefone", telefone);
                                cmd.Parameters.AddWithValue("@senha", senha);
                                cmd.Parameters.AddWithValue("@tipo_login", "Aluno");

                                cmd.ExecuteNonQuery();
                            }

                            // Pegar o ID inserido do cadastro
                            int idCadastro;
                            using (var cmdId = new MySql.Data.MySqlClient.MySqlCommand("SELECT LAST_INSERT_ID();", conn, transaction))
                            {
                                idCadastro = Convert.ToInt32(cmdId.ExecuteScalar());
                            }

                            // 2) Buscar template do plano no servidor (não vai atualizar esse template)
                            string selectPlano = @"
                        SELECT tipo, valor, data_inicio, data_fim
                        FROM Plano
                        WHERE tipo = @tipo AND id_cadastro_login IS NULL
                        LIMIT 1;";

                            string tipoPlano;
                            decimal valorPlano;
                            DateTime modeloInicio, modeloFim;

                            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(selectPlano, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@tipo", planoEscolhido);

                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (!reader.Read())
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("❌ Nenhum template de plano disponível deste tipo no servidor.",
                                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    tipoPlano = reader.GetString("tipo");
                                    valorPlano = reader.GetDecimal("valor");
                                    modeloInicio = reader.GetDateTime("data_inicio");
                                    modeloFim = reader.GetDateTime("data_fim");
                                }
                            }

                            // 3) Calcular datas com base na duração do template (começa hoje)
                            TimeSpan duracao = modeloFim - modeloInicio;
                            DateTime dataInicio = DateTime.Today;
                            DateTime dataFim = dataInicio.Add(duracao);

                            // 4) Inserir novo plano vinculado ao usuário (novo registro)
                            string insertPlano = @"
                        INSERT INTO Plano (id_cadastro_login, tipo, valor, data_inicio, data_fim)
                        VALUES (@idCadastro, @tipo, @valor, @data_inicio, @data_fim);";

                            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(insertPlano, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@idCadastro", idCadastro);
                                cmd.Parameters.AddWithValue("@tipo", tipoPlano);
                                cmd.Parameters.AddWithValue("@valor", valorPlano);
                                cmd.Parameters.AddWithValue("@data_inicio", dataInicio);
                                cmd.Parameters.AddWithValue("@data_fim", dataFim);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("✅ Cadastro e criação do plano do usuário realizados com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception exInner)
                        {
                            transaction.Rollback();
                            MessageBox.Show("❌ Erro ao cadastrar: " + exInner.Message, "Erro",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("❌ Erro no banco de dados: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro inesperado: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
