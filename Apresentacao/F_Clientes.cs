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
    public partial class F_Clientes : Form
    {
        public F_Clientes()
        {
            InitializeComponent();
            clienteController = new ClienteController(); // Inicializa o controller
        }

        private ClienteController clienteController;
        private string idSelecionado = "";
        private string tipoAcao = "";

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_primeiro_Click(object sender, EventArgs e)
        {
            Globais.primeiro(dgv_clientes);
        }

        private void tsb_anterior_Click(object sender, EventArgs e)
        {
            Globais.anterior(dgv_clientes);
        }

        private void tsb_proximo_Click(object sender, EventArgs e)
        {
            Globais.proximo(dgv_clientes);
        }

        private void tsb_ultimo_Click(object sender, EventArgs e)
        {
            Globais.ultimo(dgv_clientes);
        }

        private void tbc_control_KeyDown(object sender, KeyEventArgs e)
        {
            Globais.ControleDeKeys(dgv_clientes, tbc_control, e, tipoAcao);
        }

        private string contaResultados()
        {
            //Função para pegar resultados de um grid e informar em um lb
            string resultados = dgv_clientes.Rows.Count.ToString();
            return lb_registros.Text = resultados + " Regs";
        }

        private void alterarDados()
        {
            tbc_control.SelectedTab = tbp_dados;
            tb_nome.Enabled = true;
            mtb_documento.Enabled = true;
            cb_sexo.Enabled = true;
            tb_email.Enabled = true;
            mtb_Telefone.Enabled = true;
            dtp_datanasc.Enabled = true;
            cb_uf.Enabled = true;
            cb_cidades.Enabled = true;
            cb_status.Enabled = true;
            tb_bairro.Enabled = true;
            tb_endereco.Enabled = true;
            n_numero.Enabled = true;
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);
        }

        private void carregarGrid()
        {
            try
            {
                // Inicializa o controlador responsável pelos usuários
                clienteController = new ClienteController();

                // Popula o DataGridView com os dados da tabela Usuarios
                clienteController.PreencherDataGridView(dgv_clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Definindo tamanho da DataGridView
                dgv_clientes.Columns[0].Width = (int)(dgv_clientes.Width * 0.1);
                dgv_clientes.Columns[1].Width = (int)(dgv_clientes.Width * 0.4);
                dgv_clientes.Columns[2].Width = (int)(dgv_clientes.Width * 0.2);
                dgv_clientes.Columns[3].Width = (int)(dgv_clientes.Width * 0.15);
                dgv_clientes.Columns[4].Width = (int)(dgv_clientes.Width * 0.15);

                idSelecionado = dgv_clientes.Columns[0].ToString();
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
                var clientesFiltrados = clienteController.FiltrarClientes(termo, status);

                // Atualiza o DataGridView
                clienteController.AtualizarDataGridView(dgv_clientes, clientesFiltrados);

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
            mtb_documento.Clear();
            cb_sexo.SelectedIndex = 0;
            tb_email.Clear();
            mtb_Telefone.Clear();
            dtp_datanasc.Checked = false;
            cb_uf.SelectedIndex = 0;
            cb_cidades.SelectedIndex = 0;
            cb_status.SelectedIndex = 0;
            tb_bairro.Clear();
            tb_endereco.Clear();
            n_numero.Value = 0;
        }

        private void F_Clientes_Load(object sender, EventArgs e)
        {
            //Popular ComboBox Status (Ativo = A | Bloqueado = B | Cancelado = C | Todos = T)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("B", "Bloqueado");
            st.Add("C", "Cancelado");
            st.Add("T", "Todos");
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

            //Popular ComboBox sexo (Masculino = M | Feminino = F)
            Dictionary<string, string> sexo = new Dictionary<string, string>();
            sexo.Add("N", "Não informado");
            sexo.Add("M", "Masculino");
            sexo.Add("F", "Feminino");
            cb_sexo.Items.Clear();
            cb_sexo.DataSource = new BindingSource(sexo, null);
            cb_sexo.DisplayMember = "Value";
            cb_sexo.ValueMember = "Key";

            //Popular ComboBox Cidades
            try
            {
                CidadeController cidadeController = new CidadeController();
                List<KeyValuePair<int, string>> cidades = cidadeController.ComboBoxCidades();

                if (cidades.Any())
                {
                    cb_cidades.DataSource = new BindingSource(cidades, null);
                    cb_cidades.DisplayMember = "Value";
                    cb_cidades.ValueMember = "Key";
                }
                else
                {
                    MessageBox.Show("Nenhuma cidade encontrada no banco de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao popular ComboBox de cidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Popular ComboBox Estados
            try
            {
                EstadoController estadoController = new EstadoController();
                List<KeyValuePair<string, string>> estado = estadoController.ComboBoxEstados();

                if (estado.Any())
                {
                    cb_uf.DataSource = new BindingSource(estado, null);
                    cb_uf.DisplayMember = "Value";
                    cb_uf.ValueMember = "Key";
                }
                else
                {
                    MessageBox.Show("Nenhum estado encontrado no banco de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao popular ComboBox de estados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //selecionando idSelecionado
            idSelecionado = dgv_clientes.Rows[0].Cells[0].Value.ToString();

            // Carregando dados na Grid
            carregarGrid();

            // Verificar se existem linhas na grid
            if (dgv_clientes.Rows.Count > 0)
            {
                // Selecionar a primeira linha
                dgv_clientes.CurrentCell = dgv_clientes.Rows[0].Cells[0];
                dgv_clientes.Rows[0].Selected = true;
            }

            // Adicionar o foco à grid
            dgv_clientes.Focus();

        }

        private void tb_filtroNome_TextChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void cb_filtroStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void F_Clientes_Shown_1(object sender, EventArgs e)
        {
            dgv_clientes.Focus();
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem algum Cliente Selecionado para Excluir, caso não avisa
            if (dgv_clientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o cliente da linha selecionada
            var clienteSelecionado = new Clientes
            {
                Id = Convert.ToInt32(dgv_clientes.CurrentRow.Cells["Id"].Value),
                Nome = dgv_clientes.CurrentRow.Cells["Nome"].Value.ToString(),
                Email = dgv_clientes.CurrentRow.Cells["Email"].Value.ToString(),
                Telefone = dgv_clientes.CurrentRow.Cells["Telefone"].Value.ToString(),
                Status = dgv_clientes.CurrentRow.Cells["Status"].Value.ToString()
            };

            // Confirmação do usuário
            var confirmacao = MessageBox.Show($"Tem certeza de que deseja excluir o usuário {clienteSelecionado.Nome}?",
                                              "Confirmar Exclusão",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning, // Ícone de alerta
                                              MessageBoxDefaultButton.Button2); // Default para "Não" (botão 2)

            if (confirmacao == DialogResult.Yes)
            {
                var clienteController = new ClienteController();

                // Excluir do banco e do grid
                if (clienteController.ExcluirCliente(clienteSelecionado))
                {
                    dgv_clientes.Rows.Remove(dgv_clientes.CurrentRow);

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoAcao = "alteracao";
            alterarDados();
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(vid, out int idSelecionado))
                {
                    ClienteController clienteController = new ClienteController();
                    Clientes clienteSelecionado = clienteController.ObterClientePorId(idSelecionado);

                    if (clienteSelecionado != null)
                    {
                        tb_id.Text = clienteSelecionado.Id.ToString();
                        tb_nome.Text = clienteSelecionado.Nome;
                        mtb_documento.Text = clienteSelecionado.Documento;
                        cb_sexo.SelectedValue = clienteSelecionado.Sexo;
                        tb_email.Text = clienteSelecionado.Email;
                        mtb_Telefone.Text = clienteSelecionado.Telefone;
                        dtp_datanasc.Value = DateTime.Parse(clienteSelecionado.Datanasc);
                        cb_uf.SelectedValue = clienteSelecionado.Uf;
                        cb_cidades.SelectedValue = clienteSelecionado.CodMunicipio;
                        cb_status.SelectedValue = clienteSelecionado.Status;
                        tb_bairro.Text = clienteSelecionado.Bairro;
                        tb_endereco.Text = clienteSelecionado.Endereco;
                        n_numero.Value = clienteSelecionado.Numero;
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
            mtb_documento.Enabled = false;
            cb_sexo.Enabled = false;
            tb_email.Enabled = false;
            mtb_Telefone.Enabled = false;
            dtp_datanasc.Enabled = false;
            cb_uf.Enabled = false;
            cb_cidades.Enabled = false;
            cb_status.Enabled = false;
            tb_bairro.Enabled = false;
            tb_endereco.Enabled = false;
            n_numero.Enabled = false;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;

            if (tipoAcao == "alteracao")
            {
                idSelecionado = dgv_clientes.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                carregarGrid();
            }

            tipoAcao = null;
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);

        }

        private void tsb_incluir_Click(object sender, EventArgs e)
        {
            //Corrigindo campos após Cadastro
            tb_id.Text = Globais.gerarNovoID("tbcliente").ToString();
            LimparFormulario();
            tipoAcao = "inclusao";
            alterarDados();
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tipoAcao == "alteracao")
            {
                try
                {
                    Clientes cliente = new Clientes
                    {
                        Nome = tb_nome.Text,
                        Documento = mtb_documento.Text,
                        Sexo = cb_sexo.SelectedValue?.ToString() ?? string.Empty,
                        Email = tb_email.Text,
                        Telefone = mtb_Telefone.Text,
                        Status = cb_status.SelectedValue?.ToString() ?? string.Empty,
                        Datanasc = dtp_datanasc.Value.ToString(),
                        Uf = cb_uf.SelectedValue?.ToString() ?? string.Empty,
                        CodMunicipio = int.TryParse(cb_cidades.SelectedValue?.ToString(), out int cod) ? cod : 0,
                        Bairro = tb_bairro.Text,
                        Endereco = tb_endereco.Text,
                        Numero = (int)n_numero.Value,
                        Id = int.TryParse(tb_id.Text, out int id) ? id : 0
                    };
                    
                    // Chama o método para atualizar o Cliente
                    clienteController.AtualizarCliente(cliente);
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
                    Clientes novoCliente = new Clientes
                    {
                        Nome = tb_nome.Text,
                        Documento = mtb_documento.Text,
                        Sexo = cb_sexo.SelectedValue?.ToString() ?? string.Empty,
                        Email = tb_email.Text,
                        Telefone = mtb_Telefone.Text,
                        Status = cb_status.SelectedValue?.ToString() ?? string.Empty,
                        Datanasc = dtp_datanasc.Value.ToString(),
                        Uf = cb_uf.SelectedValue?.ToString() ?? string.Empty,
                        CodMunicipio = int.TryParse(cb_cidades.SelectedValue?.ToString(), out int cod) ? cod : 0,
                        Bairro = tb_bairro.Text,
                        Endereco = tb_endereco.Text,
                        Numero = (int)n_numero.Value
                    };

                    ClienteController clienteController = new ClienteController();
                    bool sucesso = clienteController.InserirCliente(novoCliente);

                    if (sucesso)
                    {
                        //Gera novo id após cadastro de usuario
                        tb_id.Text = Globais.gerarNovoID("tbcliente").ToString();

                        //Verifica se deseja cadastrar mais ou se deseja continuar
                        if (MessageBox.Show("Deseja Cadastrar mais um registro?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            tbc_control.SelectedTab = tbp_lista;
                            goto fim_gravar;
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar inclusão: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Erro ao salvar dados");
            }

            fim_gravar:

            // limpa o formulário
            LimparFormulario();

            // Atualiza lista do formulário
            carregarGrid();

            tbc_control.SelectedTab = tbp_lista;
            tb_nome.Enabled = false;
            mtb_documento.Enabled = false;
            cb_sexo.Enabled = false;
            tb_email.Enabled = false;
            mtb_Telefone.Enabled = false;
            dtp_datanasc.Enabled = false;
            cb_uf.Enabled = false;
            cb_cidades.Enabled = false;
            cb_status.Enabled = false;
            tb_bairro.Enabled = false;
            tb_endereco.Enabled = false;
            n_numero.Enabled = false;
            tipoAcao = null;
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);

        }
    }
}
