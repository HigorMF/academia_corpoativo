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
    public partial class frmRecepcionista : Form
    {
        public frmRecepcionista()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroAluno Aluno = new CadastroAluno();
            Aluno.ShowDialog();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Calendario Calendario = new Calendario();
            Calendario.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            DadosCadastroAluno DCA = new DadosCadastroAluno();
            DCA.ShowDialog();
        }
    }
}
