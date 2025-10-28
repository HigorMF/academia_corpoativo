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
    public partial class Aluno : Form
    {
        private int _idTurma;

        public Aluno(string nome, string matricula, string plano)
        {
            InitializeComponent();

            lbNome.Text = $"Aluno: {nome}";
            lbNumeroMatricula.Text = $"Matrícula: {matricula}";
            label2.Text = $"Plano: {plano}";
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            // Pega a data selecionada no calendário do FormAluno
            DateTime dataSelecionada = calendarRegistroFrequencia.SelectionStart;

            // Usa as variáveis internas do FormAluno (_idAluno e _idTurma)
            Frequencia frm = new Frequencia(
                _idAluno,       // id do aluno recebido no login
                _idTurma,       // id da turma do aluno
                dataSelecionada,
                this            // referência ao FormAluno
            );

            frm.ShowDialog();
        }

        private void Aluno_Load(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection con = new Conexao().GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM pagamento";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            CarregarPagamentosAluno();
            CarregarFrequenciaAluno();

        }

        private int _idAluno;

        public Aluno(string nome, string matricula, string plano, int idAluno)
        {
            InitializeComponent();

            lbNome.Text = nome;
            lbNumeroMatricula.Text = matricula;
            label2.Text = plano;

            _idAluno = idAluno;
        }

        private void CarregarPagamentosAluno()
        {
            using (var con = new Conexao().GetConnection())
            {
                con.Open();
                string query = @"SELECT p.id_pagamento, p.data_pagamento, p.valor,
                               p.forma_pagamento, p.status_pagamento
                               FROM pagamento p
                               INNER JOIN plano pl ON p.id_plano = pl.id_plano
                               WHERE pl.id_cadastro_login = @idAluno";

                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idAluno", _idAluno);

                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                dgPagamento.DataSource = dt;
            }
        }

        private void CarregarFrequenciaAluno()
        {
            using (var con = new Conexao().GetConnection())
            {
                con.Open();

                string query = @"SELECT f.id_frequencia, f.data, f.entrada, f.saida, f.id_turma
                         FROM frequencia f
                         WHERE f.id_cadastro_login = @idAluno";

                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idAluno", _idAluno);

                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                dgvMarcarFrequencia.DataSource = dt;
            }
        }

        private void CarregarDatasFrequencia()
        {
            using (var con = new Conexao().GetConnection())
            {
                con.Open();
                string query = @"SELECT data_frequencia FROM frequencia 
                         WHERE id_cadastro_login = @idAluno";

                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idAluno", _idAluno);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime data = Convert.ToDateTime(reader["data_frequencia"]);
                        calendarRegistroFrequencia.AddBoldedDate(data);
                    }
                }

                calendarRegistroFrequencia.UpdateBoldedDates();
            }
        }

        public void AtualizarCalendario(DateTime data)
        {
            calendarRegistroFrequencia.AddBoldedDate(data);
            calendarRegistroFrequencia.UpdateBoldedDates();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbNumeroMatricula_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
