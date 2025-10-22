using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace academia_corpoativo
{
    public partial class EventoForms : Form
    {
        String connString = "server=10.37.44.29; user id = root; password=root;database=corpo_ativo";

        public EventoForms()
        {
            InitializeComponent();
        }

        private void EventoForms_Load(object sender, EventArgs e)
        {
            txtData.Text = Calendario.static_ano + "/" + Calendario.static_mes + "/" + ControleDeDias1.static_dia;
        }
        

        private void btoSalvar_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO agendamento (data_agendada, horario_agendado) VALUES (@data_agendada, @horario_agendado)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data_agendada", txtData.Text);
            cmd.Parameters.AddWithValue("@horario_agendado", txtHorario.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Evento salvo com sucesso!");
            conn.Dispose();
            conn.Close();
        }
    }
}
