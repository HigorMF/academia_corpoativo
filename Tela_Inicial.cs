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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscolhaCadastro tela = new EscolhaCadastro();
            tela.MdiParent = this;
            tela.Show();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
