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
            using(var conn = conexao.GetConnection())
            {
                var email = txtUsuario.Text;
                var senha = txtSenha.Text;
                string comando =
                        "SELECT * FROM cadastro WHERE email = @email AND senha = @senha ";
                using (var cmd = new MySqlCommand(comando, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());


                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
