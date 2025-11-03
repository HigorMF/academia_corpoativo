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

        private int _idLogin;
        private int _idTurma;
        private DateTime _data;
        private Aluno _formAluno;


        public Frequencia()
        {
            InitializeComponent();
        }

        private void CarregarFrequencia(string email)
        {
            Conexao conexao = new Conexao();
            using (var conn = new Conexao().GetConnection())
            {
                conn.Open();
                string sql = @"SELECT c.id_cadastro_login, t.id_turma 
                       FROM cadastro_login c
                       JOIN turma t ON c.id_turma = t.id_turma
                       WHERE c.email = @Email";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _idLogin = reader.GetInt32("id_cadastro_login");
                            _idTurma = reader.GetInt32("id_turma");

                            // Preencher os campos visuais
                            txtID_Aluno.Text = _idLogin.ToString();
                            txtID_Turma.Text = _idTurma.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Login não encontrado!");
                            this.Close();
                        }
                    }
                }
            }

            // Bloquear edição manual
            txtID_Aluno.ReadOnly = true;
            txtID_Turma.ReadOnly = true;
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        
                Conexao conexao = new Conexao();
                using (var conn = new Conexao().GetConnection())
                {
                    conn.Open();

                    string Sql = @"INSERT INTO frequencia 
                        (id_cadastro_login, id_turma, data, entrada, saida)
                        VALUES (@idLogin, @idTurma, @data, @entrada, @saida)";

                    using (var cmd = new MySqlCommand(Sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idLogin", _idLogin);
                        cmd.Parameters.AddWithValue("@idTurma", _idTurma);
                        cmd.Parameters.AddWithValue("@data", _data.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@entrada", mtbEntrada.Text.Trim());
                        cmd.Parameters.AddWithValue("@saida", mtbSaida.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    _formAluno.AtualizarCalendario(_data);
                    MessageBox.Show("Frequência registrada com sucesso!");
                    this.Close();
                }
            
        }



        public Frequencia(int idLogin, int idTurma, DateTime data, Aluno formAluno)
        {
            InitializeComponent();
            _idLogin = idLogin;
            _idTurma = idTurma;
            _data = data;
            _formAluno = formAluno;

            // Preenche os campos visuais (somente exibição)
            txtID_Aluno.Text = _idLogin.ToString();
            txtID_Turma.Text = _idTurma.ToString();
            mtbData.Text = _data.ToString("dd/MM/yyyy");

            // Evita edição manual
            txtID_Aluno.ReadOnly = true;
            txtID_Turma.ReadOnly = true;
            mtbData.ReadOnly = true;
        }

        private void Frequencia_Load(object sender, EventArgs e)
        {
        }

    }
}