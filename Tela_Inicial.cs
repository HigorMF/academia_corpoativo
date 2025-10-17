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
        bool homeCollapse;

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
                    if (sidebar.Width == sidebar.MinimumSize.Width)
                    {
                        sidebarExpand = true;
                        sidebarTime.Stop();
                    }
                }
            }
        }

        private void btnBotao_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void HomeTime_Tick(object sender, EventArgs e)
        {
            if (homeCollapse)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapse = false;
                    HomeTime.Stop();
                }

            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapse = true;
                    HomeTime.Stop();
                }
            }
        }

        private void btnSubMenu_Click(object sender, EventArgs e)
        {
            HomeTime.Start();
        }
    }
}
