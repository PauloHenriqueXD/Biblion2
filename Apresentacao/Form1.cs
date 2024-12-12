using Biblion.Apresentacao;
using Biblion.Entities;
using Biblion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Biblion
{
    public partial class Form1 : Form
    {
        //Instanciando Variaveis locais
        int tentativaLogin = 0;

        Principal F_Principal;
        DataTable dt = new DataTable();
        public Form1(Principal f)
        {
            InitializeComponent();
            F_Principal = f;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            //Acessando e Pegando dados de login e senha do usuário
            Controle controle = new Controle();
            controle.acessar(tbLogin.Text, tbSenha.Text);
            
            //Verificando tentativas de login
            tentativaLogin++;
            if (tentativaLogin > 3)
            {
                MessageBox.Show("Máximo de Tentativas excedido, o sistema irá fechar!");
                Application.Exit();
            }

            //Verificando se usuário e senha foram informados
            if (tbLogin.Text == "" || tbSenha.Text == "")
            {
                MessageBox.Show("Usuário e/ou Senha Inválidos!");
                tbLogin.Focus();
                Globais.logado = false;
                return;
            }

            //Conferindo no banco de dados se existe o usuario e senha digitados
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    Globais.logado = true;
                    Principal principal = new Principal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbLogin.Clear();
                    tbSenha.Clear();
                    tbLogin.Focus();
                    Globais.logado = false;
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Globais.logado)
            {
                Application.Exit();
            }
        }
    }
}
