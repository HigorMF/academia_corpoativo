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
    public partial class Aluno : Form
    {
        public Aluno(string nome, string matricula, string plano)
        {
            InitializeComponent();

            lbNome.Text = $"Aluno: {nome}";
            lbNumeroMatricula.Text = $"Matrícula: {matricula}";
            label2.Text = $"Plano: {plano}";
        }


        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbNumeroMatricula_Click(object sender, EventArgs e)
        {

        }
    }
}
