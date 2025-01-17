using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblion.Apresentacao
{
    public partial class F_Usuarios : Form
    {
        public F_Usuarios()
        {
            InitializeComponent();
            usuarioController = new UsuarioController(); // Inicializa o controller
        }

        private UsuarioController usuarioController;
        private string idSelecionado = "";
        private string tipoAcao = "";
        private string destinoCompleto = "";

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_primeiro_Click(object sender, EventArgs e)
        {
            Globais.primeiro(dgv_usuarios);
        }

        private void tsb_anterior_Click(object sender, EventArgs e)
        {
            Globais.anterior(dgv_usuarios);
        }

        private void tsb_proximo_Click(object sender, EventArgs e)
        {
            Globais.proximo(dgv_usuarios);
        }

        private void tsb_ultimo_Click(object sender, EventArgs e)
        {
            Globais.ultimo(dgv_usuarios);
        }

        private string contaResultados()
        {
            //Função para pegar resultados de um grid e informar em um lb
            string resultados = dgv_usuarios.Rows.Count.ToString();
            return lb_registros.Text = resultados + " Regs";
        }

        private void alterarDados()
        {
            tbc_control.SelectedTab = tbp_dados;
            tb_nome.Enabled = true;
            tb_login.Enabled = true;
            tb_senha.Enabled = true;
            cb_status.Enabled = true;
            n_nivel.Enabled = true;
            btn_addFoto.Enabled = true;
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void carregarGrid()
        {
            try
            {
                // Inicializa o controlador responsável pelos usuários
                usuarioController = new UsuarioController();

                // Popula o DataGridView com os dados da tabela Usuarios
                usuarioController.PreencherDataGridView(dgv_usuarios); // 'dgv_usuarios' é o nome do DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Definindo tamanho da DataGridView
                dgv_usuarios.Columns[0].Width = (int)(dgv_usuarios.Width * 0.1);
                dgv_usuarios.Columns[1].Width = (int)(dgv_usuarios.Width * 0.4);
                dgv_usuarios.Columns[2].Width = (int)(dgv_usuarios.Width * 0.2);
                dgv_usuarios.Columns[3].Width = (int)(dgv_usuarios.Width * 0.15);
                dgv_usuarios.Columns[4].Width = (int)(dgv_usuarios.Width * 0.15);

                idSelecionado = dgv_usuarios.Columns[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Definir Grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //contando registros do grid
            contaResultados();
        }

        private void atualizaDados()
        {
            try
            {
                // Obtém o texto digitado no TextBox
                string termo = tb_filtroNome.Text.Trim();

                // Obtém a chave do item selecionado no ComboBox
                string status = "T"; // Valor padrão (Todos)
                if (cb_filtroStatus.SelectedItem != null)
                {
                    status = ((KeyValuePair<string, string>)cb_filtroStatus.SelectedItem).Key;
                }

                // Chama o método de filtro
                var usuariosFiltrados = usuarioController.FiltrarUsuarios(termo, status);

                // Atualiza o DataGridView
                usuarioController.AtualizarDataGridView(dgv_usuarios, usuariosFiltrados);

                //contando registros do grid
                contaResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Filtrar Grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparFormulario()
        {
            tb_nome.Clear();
            tb_login.Clear();
            tb_senha.Clear();
            cb_status.SelectedIndex = 0;
            n_nivel.Value = 0;
            pb_foto.ImageLocation = null;
        }

        private void F_Usuarios_Load(object sender, EventArgs e)
        {
            //Popular ComboBox Status (Ativo = A | Bloqueado = B | Cancelado = C | Todos = T)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("T", "Todos");
            st.Add("A", "Ativo");
            st.Add("B", "Bloqueado");
            st.Add("C", "Cancelado");
            cb_filtroStatus.Items.Clear();
            cb_filtroStatus.DataSource = new BindingSource(st, null);
            cb_filtroStatus.DisplayMember = "Value";
            cb_filtroStatus.ValueMember = "Key";

            //Popular ComboBox Status (Ativo = A | Bloqueado = B | Cancelado = C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            idSelecionado = dgv_usuarios.Rows[0].Cells[0].Value.ToString();

            // Carregando dados na Grid
            carregarGrid();

            // Verificar se existem linhas na grid
            if (dgv_usuarios.Rows.Count > 0)
            {
                // Selecionar a primeira linha
                dgv_usuarios.CurrentCell = dgv_usuarios.Rows[0].Cells[0];
                dgv_usuarios.Rows[0].Selected = true;
            }

            // Adicionar o foco à grid
            dgv_usuarios.Focus();

        }

        private void tb_filtroNome_TextChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void cb_filtroStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void tbc_control_KeyDown(object sender, KeyEventArgs e)
        {
            int tecla = e.KeyValue;
            switch (tecla)
            {
                case 40: //baixo
                    Globais.proximo(dgv_usuarios);
                    break;
                case 38: //cima
                    Globais.anterior(dgv_usuarios);
                    break;
                case 39: //direita
                    Globais.MoverParaProximaAba(tbc_control); // Usando a classe global
                    e.Handled = true;
                    break;
                case 37: //esquerda
                    Globais.MoverParaAbaAnterior(tbc_control); // Usando a classe global
                    e.Handled = true;
                    break;
            }
        }

        private void F_Usuarios_Shown(object sender, EventArgs e)
        {
            dgv_usuarios.Focus();
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem algum usuário Selecionado para Excluir, caso não avisa
            if (dgv_usuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o usuário da linha selecionada
            var usuarioSelecionado = new Usuarios
            {
                Id = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells["Id"].Value),
                Nome = dgv_usuarios.CurrentRow.Cells["Nome"].Value.ToString(),
                Login = dgv_usuarios.CurrentRow.Cells["Login"].Value.ToString(),
                Status = dgv_usuarios.CurrentRow.Cells["Status"].Value.ToString(),
                Acesso = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells["Acesso"].Value),
                Img = dgv_usuarios.CurrentRow.Cells["Img"].Value.ToString()
            };

            // Confirmação do usuário
            var confirmacao = MessageBox.Show($"Tem certeza de que deseja excluir o usuário {usuarioSelecionado.Nome}?",
                                              "Confirmar Exclusão",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning, // Ícone de alerta
                                              MessageBoxDefaultButton.Button2); // Default para "Não" (botão 2)

            if (confirmacao == DialogResult.Yes)
            {
                var usuarioController = new UsuarioController();

                // Excluir do banco e do grid
                if (usuarioController.ExcluirUsuario(usuarioSelecionado))
                {
                    dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoAcao = "alteracao";
            alterarDados();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(vid, out int idSelecionado))
                {
                    UsuarioController usuarioController = new UsuarioController();
                    Usuarios usuarioSelecionado = usuarioController.ObterUsuarioPorId(idSelecionado);

                    if (usuarioSelecionado != null)
                    {
                        tb_id.Text = usuarioSelecionado.Id.ToString();
                        tb_nome.Text = usuarioSelecionado.Nome;
                        tb_login.Text = usuarioSelecionado.Login;
                        tb_senha.Text = usuarioSelecionado.Senha;
                        cb_status.SelectedValue = usuarioSelecionado.Status;
                        n_nivel.Value = usuarioSelecionado.Acesso;
                        pb_foto.ImageLocation = usuarioSelecionado.Img;
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao converter o ID selecionado.");
                }
            }
        }

        private void tsb_alterar_Click(object sender, EventArgs e)
        {
            tipoAcao = "alteracao";
            alterarDados();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tbc_control.SelectedTab = tbp_lista;
            tb_nome.Enabled = false;
            tb_login.Enabled = false;
            tb_senha.Enabled = false;
            cb_status.Enabled = false;
            n_nivel.Enabled = false;
            btn_addFoto.Enabled = false;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;

            if(tipoAcao == "alteracao")
            {
                idSelecionado = dgv_usuarios.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                carregarGrid();
            }

            tipoAcao = "";
            
        }

        private void btn_addFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Verifica se a pasta existe; se não, cria
                string pastaImg = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");
                if (!Directory.Exists(pastaImg))
                {
                    Directory.CreateDirectory(pastaImg);
                }

                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Selecione uma Imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoImagem = openFileDialog.FileName;
                    pb_foto.ImageLocation = caminhoImagem; // Mostra a imagem no PictureBox

                    // Opcional: Salvar o caminho em uma variável para uso posterior
                    destinoCompleto = caminhoImagem;
                }
            }
        }

        private void tsb_incluir_Click(object sender, EventArgs e)
        {
            //Corrigindo campos após Cadastro
            tb_id.Text = Globais.gerarNovoID("tbusuarios").ToString();
            tb_nome.Clear();
            tb_login.Clear();
            tb_senha.Clear();
            cb_status.SelectedIndex = 0;
            n_nivel.Value = 0;
            pb_foto.ImageLocation = "";
            tipoAcao = "inclusao";
            alterarDados();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //Verifica se foi selecionada foto e pergunta se deseja continuar
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            if (tipoAcao == "alteracao")
            {
                try
                {
                    Usuarios usuario = new Usuarios
                    {
                        Id = int.Parse(tb_id.Text),
                        Nome = tb_nome.Text,
                        Login = tb_login.Text,
                        Senha = tb_senha.Text,
                        Status = cb_status.SelectedValue.ToString(),
                        Acesso = (int)n_nivel.Value,
                        Img = pb_foto.ImageLocation // Caminho atual da imagem
                    };

                    // Chama o método para atualizar o usuário
                    string caminhoImagemSelecionada = destinoCompleto; // Caminho da imagem carregada pelo usuário
                    usuarioController.AtualizarUsuario(usuario, caminhoImagemSelecionada);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
                }
                tbc_control.SelectedTab = tbp_lista;
                tb_nome.Enabled = false;
                tb_login.Enabled = false;
                tb_senha.Enabled = false;
                cb_status.Enabled = false;
                n_nivel.Enabled = false;
                btn_addFoto.Enabled = false;
                btn_gravar.Enabled = false;
                btn_cancelar.Enabled = false;
            }
            else if (tipoAcao == "inclusao")
            {
                try
                {
                    Usuarios novoUsuario = new Usuarios
                    {
                        Nome = tb_nome.Text,
                        Login = tb_login.Text,
                        Senha = tb_senha.Text,
                        Status = cb_status.SelectedValue.ToString(),
                        Acesso = (int)n_nivel.Value,
                        Img = !string.IsNullOrEmpty(pb_foto.ImageLocation) ? pb_foto.ImageLocation : null
                    };

                    UsuarioController usuarioController = new UsuarioController();
                    bool sucesso = usuarioController.InserirUsuario(novoUsuario);

                    if (sucesso)
                    {
                        // limpa o formulário
                        LimparFormulario();

                        // Atualiza lista do formulário
                        carregarGrid();

                        //Gera novo id após cadastro de usuario
                        tb_id.Text = Globais.gerarNovoID("tbusuarios").ToString();

                        //Verifica se foi selecionada foto e pergunta se deseja continuar
                        if (MessageBox.Show("Deseja Cadastrar mais um registro?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            tbc_control.SelectedTab = tbp_lista;
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Erro ao salvar dados");
            }
            
        }
    }
}
