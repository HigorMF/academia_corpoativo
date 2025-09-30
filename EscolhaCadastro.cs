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
    public partial class EscolhaCadastro : Form
    {
        public EscolhaCadastro()
        {
            InitializeComponent();
        }

        private void btoRecepcionista_Click(object sender, EventArgs e)
        {
            CadastroRecepcionista tela = new CadastroRecepcionista();
            tela.ShowDialog();
        }

        private void btoProfesor_Click(object sender, EventArgs e)
        {
            CadastroProfessor tela = new CadastroProfessor();
            tela.ShowDialog();
        }

        private void btoAluno_Click(object sender, EventArgs e)
        {
            CadastroAluno tela = new CadastroAluno();
            tela.ShowDialog();
        }
    }
}
