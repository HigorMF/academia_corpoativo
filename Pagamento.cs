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
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                
            }
        }
    }
}
