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
    public partial class CadastroPlano : Form
    {
        public CadastroPlano()
        {
            InitializeComponent();
        }

        private void btnCadastroPlano_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                var tipo = txtTipo.Text;
                var valor = txtValor.Text;
                var data_inicio = mtbDataInicio.Text;
                var data_fim = mtbDataFim.Text;

            }
        }
    }
}
