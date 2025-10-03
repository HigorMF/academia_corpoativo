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
            var planoSelecionado = cboTipoPlano.SelectedItem?.ToString();

            // Validações
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(planoSelecionado))
            {
                MessageBox.Show("⚠️ Todos os campos, incluindo o plano, devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!nome.Contains(" "))
            {
                MessageBox.Show("⚠️ Digite o nome completo (com sobrenome).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexao conexao = new Conexao();
                using (var conn = conexao.GetConnection())
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        // Inserir cadastro_login e obter id retornado
                        string comandoCadastro = "INSERT INTO cadastro_login (nome, cpf, email, telefone, senha, tipo_login) " +
                                                 "VALUES (@nome, @cpf, @email, @telefone, @senha, @tipo_login)";
                        long idCadastroLogin;

                        using (var cmd = new MySqlCommand(comandoCadastro, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@cpf", cpf);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@telefone", telefone);
                            cmd.Parameters.AddWithValue("@senha", senha);
                            cmd.Parameters.AddWithValue("@tipo_login", "Alunos");
                            cmd.ExecuteNonQuery();
                            idCadastroLogin = cmd.LastInsertedId;
                        }

                        // Mapear o id do plano escolhido pelo texto selecionado no combobox
                        int idPlano = 0;
                        decimal valorPlano = 0;
                        DateTime dataInicio = DateTime.Now;
                        DateTime dataFim;

                        switch (planoSelecionado)
                        {
                            case "Ouro(Plano anual)":
                                idPlano = 6;
                                valorPlano = 1200.00m; // exemplo, substituir pelo real
                                dataFim = dataInicio.AddYears(1);
                                break;
                            case "Prata(Plano anual)":
                                idPlano = 7;
                                valorPlano = 900.00m; // exemplo
                                dataFim = dataInicio.AddYears(1);
                                break;
                            case "Bronze(Plano mensal)":
                                idPlano = 8;
                                valorPlano = 100.00m; // exemplo
                                dataFim = dataInicio.AddMonths(1);
                                break;
                            default:
                                MessageBox.Show("Plano inválido selecionado.", "Erro", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        // Inserir dados na tabela Plano associando ao cadastro
                        string comandoPlano = "INSERT INTO Plano (id_cadastro_login, tipo, valor, data_inicio, data_fim) " +
                                              "VALUES (@id_cadastro_login, @tipo, @valor, @data_inicio, @data_fim)";

                        using (var cmdPlano = new MySqlCommand(comandoPlano, conn, trans))
                        {
                            cmdPlano.Parameters.AddWithValue("@id_cadastro_login", idCadastroLogin);
                            cmdPlano.Parameters.AddWithValue("@tipo", planoSelecionado);
                            cmdPlano.Parameters.AddWithValue("@valor", valorPlano);
                            cmdPlano.Parameters.AddWithValue("@data_inicio", dataInicio.Date);
                            cmdPlano.Parameters.AddWithValue("@data_fim", dataFim.Date);
                            cmdPlano.ExecuteNonQuery();
                        }

                        trans.Commit();

                        MessageBox.Show("✅ Cadastro e plano realizados com sucesso!", 
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("❌ Erro no banco de dados: " + 
                    ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro inesperado: " + 
                    ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
