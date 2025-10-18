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
        bool sidebarExpand;

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
            Login tela = new Login();
            tela.MdiParent = this;
            tela.Show();
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                
                sidebar.Width -= -10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {

                    sidebarExpand = false;
                    sidebarTime.Stop();

                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        sidebarTime.Stop();
                    }
                }
            }
        }

        private void btnBotao_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenu_Click(object sender, EventArgs e)
        {
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            Login LoginMenu = new Login();
            LoginMenu.ShowDialog();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
