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
    public partial class TelaInicial : Form
    {
        bool sidebarexpand;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {

        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            {
                if (sidebarexpand)
                {
                    sidebar.Width -= 10;
                    if (sidebar.Width == sidebar.MinimumSize.Width)
                    {
                        sidebarexpand = false;
                        sidebarTimer.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarexpand = true;
                        sidebarTimer.Stop();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnConheca_Click(object sender, EventArgs e)
        {
        }
    }
}
