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
                string comando =
                        "SELECT * FROM cadastro_login WHERE email = @email AND senha = @senha ";
                using (var cmd = new MySqlCommand(comando, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipoUsuario = reader["tipo_login"].ToString();

                            switch (tipoUsuario.ToLower())
                            {
                                case "aluno":
                                    MessageBox.Show("Login de aluno realizado!");
                                    Aluno formAluno = new Aluno();
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
    }
}
