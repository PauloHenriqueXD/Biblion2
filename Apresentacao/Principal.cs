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
                    lbversao.Text = "Versão: " + Globais.versao;
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

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Globais.logado = false;
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Usuarios f_Usuarios = new F_Usuarios();
            AbreForm(0, f_Usuarios);
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_Clientes f_Clientes = new F_Clientes();
            AbreForm(0, f_Clientes);
        }
    }
}
