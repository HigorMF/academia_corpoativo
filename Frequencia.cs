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
        private int _idAluno;
        private int _idTurma;
        private DateTime _data;
        private Aluno _formAluno;

        public Frequencia(int idAluno, int idTurma, DateTime data, Aluno formAluno)
        {
            InitializeComponent();

            _idAluno = idAluno;
            _idTurma = idTurma;
            _data = data;
            _formAluno = formAluno;

            txtID_Aluno.Text = _idAluno.ToString();
            txtID_Turma.Text = _idTurma.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (var conn = new Conexao().GetConnection())
            {
                string Sql = @"INSERT INTO frequencia 
                               (id_cadastro_login, id_turma, data, entrada, saida)
                               VALUES (@id_cadastro_login, @id_turma, @data, @entrada, @saida)";

                using (var cmd = new MySqlCommand(Sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_cadastro_login", _idAluno);
                    cmd.Parameters.AddWithValue("@id_turma", _idTurma);
                    cmd.Parameters.AddWithValue("@data", _data.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@entrada", mtbEntrada.Text.Trim());
                    cmd.Parameters.AddWithValue("@saida", mtbSaida.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                _formAluno.AtualizarCalendario(_data);

                MessageBox.Show("Frequência registrada com sucesso!");
                this.Close();
            }
        }

        private void Frequencia_Load(object sender, EventArgs e)
        {
        }
    }
}