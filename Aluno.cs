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
        public Aluno(string nome, string matricula, string plano)
        {
            InitializeComponent();

            lbNome.Text = $"Aluno: {nome}";
            lbNumeroMatricula.Text = $"Matrícula: {matricula}";
            label2.Text = $"Plano: {plano}";
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

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            Frequencia frequencia = new Frequencia();
            frequencia.Show();
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
                         INNER JOIN matricula m ON p.id_plano = m.id_plano
                         WHERE m.id_cadastro_login = @idAluno";

                      var cmd = new MySqlCommand(query, con);
                      cmd.Parameters.AddWithValue("@idAluno", _idAluno);

                      var da = new MySqlDataAdapter(cmd);
                      var dt = new DataTable();
                      da.Fill(dt);

                    dgPagamento.DataSource = dt;
                }
            }
        }
    }
