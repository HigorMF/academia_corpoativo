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
using static System.Net.Mime.MediaTypeNames;

namespace academia_corpoativo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                var email = txtUsuario.Text;
                var senha = txtSenha.Text;

                string comando = @"
                    SELECT 
                        c.nome,
                        c.id_cadastro_login,
                        m.id_matricula,
                        p.tipo,
                        c.tipo_login
                    FROM cadastro_login AS c
                    LEFT JOIN matricula AS m ON c.id_cadastro_login = m.id_cadastro_login
                    LEFT JOIN plano AS p ON m.id_cadastro_login = p.id_cadastro_login
                    WHERE c.email = @Email AND c.senha = @Senha;";

                using (var cmd = new MySqlCommand(comando, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);


                    conn.Open();

                    //int count = Convert.ToInt32(cmd.ExecuteScalar());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipoUsuario = reader["tipo_login"].ToString();
                            string id_login = reader["id_cadastro_login"].ToString();
                            int id_login2 = Convert.ToInt32(id_login);
                            string matri = reader["id_matricula"].ToString();
                            string tipoplano = reader["tipo"].ToString();
                            switch (tipoUsuario.ToLower())
                            {
                                case "aluno":
                                    MessageBox.Show("Login de aluno realizado!");

                                    string nome = reader["nome"].ToString();

                                    string plano = "";

                                    Aluno formAluno = new Aluno(nome, matri, tipoplano);
                                    formAluno.Show();
                                    this.Hide();
                                    break;

                                case "professor":
                                    MessageBox.Show("Login de professor realizado!");
                                    Professor formProfessor = new Professor();
                                    formProfessor.Show();
                                    this.Hide();
                                    break;

                                case "recepcionista":
                                    MessageBox.Show("Login de recepcionista realizado!");
                                    Recepcionista formRecepcionista = new Recepcionista();
                                    formRecepcionista.Show();
                                    this.Hide();
                                    break;

                                default:
                                    MessageBox.Show("Tipo de usuário não reconhecido!");
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos!");
                        }
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !checkSenha.Checked;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void linkReseteSenhaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarSenha formRecuperar = new RecuperarSenha();
            formRecuperar.ShowDialog();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroAluno LoginCadastro = new CadastroAluno();
            LoginCadastro.ShowDialog();
        }
    }
}
