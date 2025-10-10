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
    public partial class Cadastro_Turmacs : Form
    {
        public Cadastro_Turmacs()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                var horario = textHorario.Text;
                var data_inicio = mtbDataInicio.Text;
                var data_fim = mtbDataFim.Text;

                string sql = "INSERT INTO Turma (horario, data_inicio, data_fim), VALUES(@horario, @data_inicio, data_fim)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@horario", horario);
                    cmd.Parameters.AddWithValue("@data_inicio,", data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", data_fim);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Turma cadastrada com sucesso");
                
                }
            }

        }
    }
}
