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
    public partial class F_Livros : Form
    {
        public F_Livros()
        {
            InitializeComponent();
            livroController = new LivroController(); // Inicializa o controller
        }

        private LivroController livroController;
        private string idSelecionado = "";
        private string tipoAcao = "";
        private string destinoCompleto = "";

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_primeiro_Click(object sender, EventArgs e)
        {
            Globais.primeiro(dgv_livros);
        }

        private void tsb_anterior_Click(object sender, EventArgs e)
        {
            Globais.anterior(dgv_livros);
        }

        private void tsb_proximo_Click(object sender, EventArgs e)
        {
            Globais.proximo(dgv_livros);
        }

        private void tsb_ultimo_Click(object sender, EventArgs e)
        {
            Globais.ultimo(dgv_livros);
        }

        private void tbc_control_KeyDown(object sender, KeyEventArgs e)
        {
            Globais.ControleDeKeys(dgv_livros, tbc_control, e, tipoAcao);
        }

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Globais.justNumbers(e);
        }

        private void tb_numeroPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Globais.justNumbers(e);
        }

        private string contaResultados()
        {
            //Função para pegar resultados de um grid e informar em um lb
            string resultados = dgv_livros.Rows.Count.ToString();
            return lb_registros.Text = resultados + " Regs";
        }

        private void alterarDados()
        {
            tbc_control.SelectedTab = tbp_dados;
            tb_ISBN.Enabled = true;
            tb_titulo.Enabled = true;
            tb_autores.Enabled = true;
            tb_editora.Enabled = true;
            dtp_dataPublicacao.Enabled = true;
            rtb_descricao.Enabled = true;
            tb_numeroPaginas.Enabled = true;
            tb_categoria.Enabled = true;
            tb_idioma.Enabled = true;
            cb_status.Enabled = true;
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar, btn_addFoto };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);
        }

        private void carregarGrid()
        {
            try
            {
                // Inicializa o controlador responsável pelos Registros
                livroController = new LivroController();

                // Popula o DataGridView com os dados da tabela
                livroController.PreencherDataGridView(dgv_livros); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Definindo tamanho da DataGridView
                dgv_livros.Columns[0].Width = (int)(dgv_livros.Width * 0.05);
                dgv_livros.Columns[1].Width = (int)(dgv_livros.Width * 0.2);
                dgv_livros.Columns[2].Width = (int)(dgv_livros.Width * 0.3);
                dgv_livros.Columns[3].Width = (int)(dgv_livros.Width * 0.3);
                dgv_livros.Columns[4].Width = (int)(dgv_livros.Width * 0.15);
                dgv_livros.Columns[5].Width = (int)(dgv_livros.Width * 0.1);

                idSelecionado = dgv_livros.Columns[0].ToString();
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
                var livrosFiltrados = livroController.FiltrarLivros(termo, status);

                // Atualiza o DataGridView
                livroController.AtualizarDataGridView(dgv_livros, livrosFiltrados);

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
            tb_ISBN.Clear();
            tb_titulo.Clear();
            tb_autores.Clear();
            tb_editora.Clear();
            tb_numeroPaginas.Clear();
            tb_categoria.Clear();
            tb_idioma.Clear();
            cb_status.SelectedIndex = 0;
            dtp_dataPublicacao.Checked = false;
            rtb_descricao.Clear();
            pb_foto.ImageLocation = null;
            destinoCompleto = null;
        }

        private void F_Livros_Load(object sender, EventArgs e)
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

            if (dgv_livros.Rows.Count > 0 && dgv_livros.Rows[0].Cells.Count > 0)
            {
                idSelecionado = dgv_livros.Rows[0].Cells[0].Value?.ToString();
            }
            else
            {
                idSelecionado = string.Empty;
            }

            // Carregando dados na Grid
            carregarGrid();

            // Verificar se existem linhas na grid
            if (dgv_livros.Rows.Count > 0)
            {
                // Selecionar a primeira linha
                dgv_livros.CurrentCell = dgv_livros.Rows[0].Cells[0];
                dgv_livros.Rows[0].Selected = true;
            }

            // Adicionar o foco à grid
            dgv_livros.Focus();

        }

        private void tb_filtroNome_TextChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void cb_filtroStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void F_Livros_Shown(object sender, EventArgs e)
        {
            dgv_livros.Focus();
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem algum registro Selecionado para Excluir, caso não avisa
            if (dgv_livros.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o registro da linha selecionada
            var livroSelecionado = new Livros
            {
                Id = Convert.ToInt32(dgv_livros.CurrentRow.Cells["Id"].Value),
                ISBN = dgv_livros.CurrentRow.Cells["ISBN"].Value.ToString(),
                Titulo = dgv_livros.CurrentRow.Cells["Título"].Value.ToString(),
                Autores = dgv_livros.CurrentRow.Cells["Autores"].Value.ToString(),
                DataPublicacao = Convert.ToDateTime(dgv_livros.CurrentRow.Cells["Data da Publicação"].Value.ToString()),
                Status = dgv_livros.CurrentRow.Cells["Status"].Value.ToString()
            };

            // Confirmação do usuário
            var confirmacao = MessageBox.Show($"Tem certeza de que deseja excluir o registro {livroSelecionado.Titulo}?",
                                              "Confirmar Exclusão",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning, // Ícone de alerta
                                              MessageBoxDefaultButton.Button2); // Default para "Não" (botão 2)

            if (confirmacao == DialogResult.Yes)
            {
                var livroController = new LivroController();

                // Excluir do banco e do grid
                if (livroController.ExcluirLivros(livroSelecionado))
                {
                    dgv_livros.Rows.Remove(dgv_livros.CurrentRow);

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_livros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoAcao = "alteracao";
            alterarDados();
        }

        private void dgv_livros_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(vid, out int idSelecionado))
                {
                    LivroController livroController = new LivroController();
                    Livros livroSelecionado = livroController.ObterLivrosPorId(idSelecionado);

                    if (livroSelecionado != null)
                    {
                        tb_id.Text = livroSelecionado.Id.ToString();
                        tb_ISBN.Text = livroSelecionado.ISBN;
                        tb_titulo.Text = livroSelecionado.Titulo;
                        tb_autores.Text = livroSelecionado.Autores;
                        tb_editora.Text = livroSelecionado.Editora;
                        dtp_dataPublicacao.Value = livroSelecionado.DataPublicacao ?? DateTime.Today;
                        rtb_descricao.Text = livroSelecionado.Descricao;
                        tb_numeroPaginas.Text = livroSelecionado.NumeroPaginas.ToString();
                        tb_categoria.Text = livroSelecionado.Categoria;
                        tb_idioma.Text = livroSelecionado.Idioma;
                        cb_status.SelectedValue = livroSelecionado.Status;
                        pb_foto.ImageLocation = livroSelecionado.UrlCapa;
                        destinoCompleto = livroSelecionado.UrlCapa;
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
            tb_ISBN.Enabled = false;
            tb_titulo.Enabled = false;
            tb_autores.Enabled = false;
            tb_editora.Enabled = false;
            dtp_dataPublicacao.Enabled = false;
            rtb_descricao.Enabled = false;
            tb_numeroPaginas.Enabled = false;
            tb_categoria.Enabled = false;
            tb_idioma.Enabled = false;
            cb_status.Enabled = false;

            if (tipoAcao == "alteracao")
            {
                idSelecionado = dgv_livros.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                carregarGrid();
            }

            tipoAcao = null;
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar, btn_addFoto };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);

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
            tb_id.Text = Globais.gerarNovoID("tblivros").ToString();
            LimparFormulario();
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
                    Livros livro = new Livros
                    {
                        Id = int.Parse(tb_id.Text),
                        ISBN = tb_ISBN.Text,
                        Titulo = tb_titulo.Text,
                        Autores = tb_autores.Text,
                        Editora = tb_editora.Text,
                        DataPublicacao = dtp_dataPublicacao.Value,
                        Descricao = rtb_descricao.Text,
                        NumeroPaginas = int.Parse(tb_numeroPaginas.Text),
                        Categoria = tb_categoria.Text,
                        Idioma = tb_idioma.Text,
                        Status = cb_status.SelectedValue.ToString(),
                        UrlCapa = !string.IsNullOrEmpty(pb_foto.ImageLocation) ? pb_foto.ImageLocation : null
                    };

                    // Chama o método para atualizar o registro
                    string caminhoImagemSelecionada = destinoCompleto; // Caminho da imagem carregada pelo usuário
                    livroController.AtualizarLivros(livro, caminhoImagemSelecionada);

                    // limpa o formulário
                    LimparFormulario();

                    // Atualiza lista do formulário
                    carregarGrid();

                    MessageBox.Show("Livro atualizado com sucesso!");

                    tbc_control.SelectedTab = tbp_lista;
                    tb_ISBN.Enabled = false;
                    tb_titulo.Enabled = false;
                    tb_autores.Enabled = false;
                    tb_editora.Enabled = false;
                    dtp_dataPublicacao.Enabled = false;
                    rtb_descricao.Enabled = false;
                    tb_numeroPaginas.Enabled = false;
                    tb_categoria.Enabled = false;
                    tb_idioma.Enabled = false;
                    cb_status.Enabled = false;
                    tipoAcao = null;
                    List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar, btn_addFoto };
                    Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
                }
               
            }
            else if (tipoAcao == "inclusao")
            {
                try
                {
                    Livros novoLivro = new Livros
                    {
                        ISBN = tb_ISBN.Text,
                        Titulo = tb_titulo.Text,
                        Autores = tb_autores.Text,
                        Editora = tb_editora.Text,
                        DataPublicacao = dtp_dataPublicacao.Value,
                        Descricao = rtb_descricao.Text,
                        NumeroPaginas = int.Parse(tb_numeroPaginas.Text),
                        Categoria = tb_categoria.Text,
                        Idioma = tb_idioma.Text,
                        Status = cb_status.SelectedValue.ToString(),
                        UrlCapa = !string.IsNullOrEmpty(pb_foto.ImageLocation) ? pb_foto.ImageLocation : null
                    };

                    LivroController livroController = new LivroController();
                    bool sucesso = livroController.InserirLivros(novoLivro);

                    if (sucesso)
                    {
                        // limpa o formulário
                        LimparFormulario();

                        // Atualiza lista do formulário
                        carregarGrid();

                        //Gera novo id após cadastro de usuario
                        tb_id.Text = Globais.gerarNovoID("tblivros").ToString();

                        MessageBox.Show("Livro cadastrado com sucesso!");

                        //Verifica se foi selecionada foto e pergunta se deseja continuar
                        if (MessageBox.Show("Deseja Cadastrar mais um registro?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            tbc_control.SelectedTab = tbp_lista;
                            tb_ISBN.Enabled = false;
                            tb_titulo.Enabled = false;
                            tb_autores.Enabled = false;
                            tb_editora.Enabled = false;
                            dtp_dataPublicacao.Enabled = false;
                            rtb_descricao.Enabled = false;
                            tb_numeroPaginas.Enabled = false;
                            tb_categoria.Enabled = false;
                            tb_idioma.Enabled = false;
                            cb_status.Enabled = false;
                            tipoAcao = null;
                            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar, btn_addFoto };
                            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);
                        }
                        else
                        {
                            // limpa o formulário
                            LimparFormulario();

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
