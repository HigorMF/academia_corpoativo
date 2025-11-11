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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace academia_corpoativo
{
    public partial class Aluno : Form
    {
        private int _idTurma;
        private int _idAluno;

        public Aluno(string nome, string matricula, string plano, int idAluno, int idTurma)
        {
            InitializeComponent();

            lbNome.Text = $"Aluno: {nome}";
            lbNumeroMatricula.Text = $"Matrícula: {matricula}";
            label2.Text = $"Plano: {plano}";

            _idAluno = idAluno;
            _idTurma = idTurma;
        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarPagamentosAluno();
                CarregarFrequenciaAluno();
                CarregarDatasFrequencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do aluno: " + ex.Message);
            }
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
                string query = @"SELECT data FROM frequencia 
                                 WHERE id_cadastro_login = @idAluno";

                var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idAluno", _idAluno);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime data = Convert.ToDateTime(reader["data"]);
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

        // ✅ Botão Frequência
        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idAluno <= 0)
                {
                    MessageBox.Show("ID do aluno inválido. Verifique o login.");
                    return;
                }

                if (_idTurma <= 0)
                {
                    MessageBox.Show("Este aluno ainda não está vinculado a uma turma.");
                    return;
                }

                DateTime dataAtual = DateTime.Now;

                Frequencia formFrequencia = new Frequencia(_idAluno, _idTurma, dataAtual, this);
                formFrequencia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o formulário de frequência: " + ex.Message);
            }
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
