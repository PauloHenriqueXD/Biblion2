using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblion.Apresentacao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            if (Globais.logado != true)
            {
                Application.Exit();
            }
        }

        private void AbreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de Acesso Não Permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário Estar Logado");
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globais.logado = false;
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globais.logado = false;
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
