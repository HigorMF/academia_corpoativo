using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public partial class ControleDeDias1 : UserControl
    {

        private ContextMenuStrip menuStatus;

        public static int static_dia;
        public ControleDeDias1()
        {
            InitializeComponent();

            menuStatus = new ContextMenuStrip();
            menuStatus.Items.Add("Confirmado").Click += (s, e) => AtualizarStatus("CONFIRMADO");
            menuStatus.Items.Add("Cancelado").Click += (s, e) => AtualizarStatus("CANCELADO");
            menuStatus.Items.Add("Remarcado").Click += (s, e) => AtualizarStatus("REMARCADO");
            menuStatus.Items.Add("Compareceu").Click += (s, e) => AtualizarStatus("COMPARECEU");

        }


        private void AtualizarStatus(string novoStatus)
        {
            try
            {
                string diaFormatado = lblDia.Text.PadLeft(2, '0');
                string mesFormatado = Calendario.static_mes.PadLeft(2, '0');
                string dataCompleta = $"{Calendario.static_ano}-{mesFormatado}-{diaFormatado}";

                using (var conn = new Conexao().GetConnection())
                {
                    conn.Open();

                    string sql = "UPDATE agendamento SET status = @status WHERE data_agendada = @data_agendada";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", novoStatus);
                        cmd.Parameters.AddWithValue("@data_agendada", dataCompleta);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Atualiza cor e texto na tela
                switch (novoStatus.ToUpper())
                {
                    case "CONFIRMADO":
                        lblInformacao.BackColor = Color.Green;
                        break;
                    case "CANCELADO":
                        lblInformacao.BackColor = Color.Red;
                        break;
                    case "REMARCADO":
                        lblInformacao.BackColor = Color.Orange;
                        break;
                    case "COMPARECEU":
                        lblInformacao.BackColor = Color.LightBlue;
                        break;
                    default:
                        lblInformacao.BackColor = Color.LightGray;
                        break;
                }

                lblInformacao.ForeColor = Color.Black;
                lblInformacao.Refresh();

                MessageBox.Show($"Status alterado para {novoStatus} com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar status: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ControleDeDias1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Mostra o menu na posição do mouse
                menuStatus.Show(this, e.Location);
            }
        }


        private void ControleDeDias1_Load(object sender, EventArgs e)
        {
            displayInformacao();
        }

        public void Days(int numday)
        {
            lblDia.Text = numday + "";
        }

        private void ControleDeDias1_Click(object sender, EventArgs e)
        {
            static_dia = Convert.ToInt32(lblDia.Text);
            timer1.Start();

            EventoForms eventoForm = new EventoForms();

            // exibe o formulário e espera ele ser fechado
            eventoForm.ShowDialog();

            // depois que o usuário fechar o EventoForms, atualiza o calendário
            if (Application.OpenForms["Calendario"] is Calendario calendario)
            {
                calendario.AtualizarCalendario();
            }

        }

        public void displayInformacao()
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {

                try
                {
                    string diaFormatado = lblDia.Text.PadLeft(2, '0');
                    string mesFormatado = Calendario.static_mes.PadLeft(2, '0');
                    string dataCompleta = $"{Calendario.static_ano}-{mesFormatado}-{diaFormatado}";

                    string sql = $@"
                                    SELECT 
                                        a.sobre, 
                                        a.status,
                                        c.nome AS nome_professor,
                                        a.horario_agendado
                                FROM agendamento a
                                JOIN cadastro_login c ON a.id_cadastro_login = c.id_cadastro_login
                                WHERE a.data_agendada = @data_agendada
                                LIMIT 1";

                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@data_agendada", dataCompleta);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string sobre = reader["sobre"].ToString();
                                string professor = reader["nome_professor"].ToString();
                                string status = reader["status"].ToString();
                                string horario = reader["horario_agendado"].ToString();

                                // 🔸 Texto dentro do quadrado
                                lblInformacao.Text = $"{professor}\n{horario}";

                                // 🔸 Criação do ToolTip (balão)
                                ToolTip detalheToolTip = new ToolTip();
                                detalheToolTip.ToolTipTitle = "Detalhes do Agendamento";
                                detalheToolTip.ToolTipIcon = ToolTipIcon.Info;
                                detalheToolTip.IsBalloon = true;
                                detalheToolTip.SetToolTip(lblInformacao,
                                    $"Horário: {horario}\nProfessor: {professor}\nStatus: {status}\nSobre: {sobre}");

                                // 🔸 Define a cor de fundo conforme o status
                                switch (status.ToUpper())
                                {
                                    case "CONFIRMADO":
                                        lblInformacao.BackColor = Color.Green;
                                        break;
                                    case "CANCELADO":
                                        lblInformacao.BackColor = Color.Red;
                                        break;
                                    case "REMARCADO":
                                        lblInformacao.BackColor = Color.Orange;
                                        break;
                                    case "COMPARECEU":
                                        lblInformacao.BackColor = Color.LightBlue;
                                        break;
                                    default:
                                        lblInformacao.BackColor = Color.LightGray;
                                        break;
                                }

                                lblInformacao.ForeColor = Color.Black;
                            }
                                else
                                {
                                    lblInformacao.Text = ""; // sem agendamento
                                }
                            }
                        }                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro em displayInformacao: " + ex.Message);
                    lblInformacao.Text = "";
                    lblInformacao.BackColor = Color.Transparent;

                }

                this.MouseUp += ControleDeDias1_MouseUp;
                lblInformacao.MouseUp += ControleDeDias1_MouseUp;
                lblInformacao.Refresh();

            }
        } 
        


        
    }
}


