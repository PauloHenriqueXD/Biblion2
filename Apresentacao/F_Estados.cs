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
    public partial class F_Estados : Form
    {
        public F_Estados()
        {
            InitializeComponent();
            estadoController = new EstadoController(); // Inicializa o controller
        }

        private EstadoController estadoController;
        private string idSelecionado = "";
        private string tipoAcao = "";

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_primeiro_Click(object sender, EventArgs e)
        {
            Globais.primeiro(dgv_estados);
        }

        private void tsb_anterior_Click(object sender, EventArgs e)
        {
            Globais.anterior(dgv_estados);
        }

        private void tsb_proximo_Click(object sender, EventArgs e)
        {
            Globais.proximo(dgv_estados);
        }

        private void tsb_ultimo_Click(object sender, EventArgs e)
        {
            Globais.ultimo(dgv_estados);
        }

        private void tbc_control_KeyDown(object sender, KeyEventArgs e)
        {
            Globais.ControleDeKeys(dgv_estados, tbc_control, e, tipoAcao);
        }

        private string contaResultados()
        {
            //Função para pegar resultados de um grid e informar em um lb
            string resultados = dgv_estados.Rows.Count.ToString();
            return lb_registros.Text = resultados + " Regs";
        }

        private void alterarDados()
        {
            tbc_control.SelectedTab = tbp_dados;
            tb_sigla.Enabled = true;
            tb_descricao.Enabled = true;
            List<Button> listaDeBotoes = new List<Button> { btn_gravar, btn_cancelar };
            Globais.ConfiguraBotoes(tipoAcao, listaDeBotoes, tsb_primeiro, tsb_anterior, tsb_proximo, tsb_ultimo, tsb_excluir, tsb_incluir, tsb_alterar, tsb_sair);
        }

        private void carregarGrid()
        {
            try
            {
                // Inicializa o controlador responsável pelos usuários
                estadoController = new EstadoController();

                // Popula o DataGridView com os dados da tabela Usuarios
                estadoController.PreencherDataGridView(dgv_estados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Definindo tamanho da DataGridView
                dgv_estados.Columns[0].Width = (int)(dgv_estados.Width * 0.1);
                dgv_estados.Columns[1].Width = (int)(dgv_estados.Width * 0.3);
                dgv_estados.Columns[2].Width = (int)(dgv_estados.Width * 0.6);

                idSelecionado = dgv_estados.Columns[0].ToString();
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

                // Chama o método de filtro
                var estadosFiltrados = estadoController.FiltrarEstados(termo);

                // Atualiza o DataGridView
                estadoController.AtualizarDataGridView(dgv_estados, estadosFiltrados);

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
            tb_sigla.Clear();
            tb_descricao.Clear();
        }

        private void F_Estados_Load(object sender, EventArgs e)
        {
            // Carregando dados na Grid
            carregarGrid();

            // Verificar se existem linhas na grid
            if (dgv_estados.Rows.Count > 0)
            {
                // Selecionar a primeira linha
                idSelecionado = dgv_estados.Rows[0].Cells[0].Value.ToString();
                dgv_estados.CurrentCell = dgv_estados.Rows[0].Cells[0];
                dgv_estados.Rows[0].Selected = true;
            }

            // Adicionar o foco à grid
            dgv_estados.Focus();

        }

        private void tb_filtroNome_TextChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void cb_filtroStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void F_Estados_Shown(object sender, EventArgs e)
        {
            dgv_estados.Focus();
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem algum usuário Selecionado para Excluir, caso não avisa
            if (dgv_estados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o Registro da linha selecionada
            var estadoSelecionado = new Estados
            {
                Id = Convert.ToInt32(dgv_estados.CurrentRow.Cells["Id"].Value),
                Sigla = dgv_estados.CurrentRow.Cells["Sigla"].Value.ToString(),
                Descricao = dgv_estados.CurrentRow.Cells["Descricao"].Value.ToString()
            };

            // Confirmação do Registro
            var confirmacao = MessageBox.Show($"Tem certeza de que deseja excluir o estado {estadoSelecionado.Descricao}?",
                                              "Confirmar Exclusão",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning, // Ícone de alerta
                                              MessageBoxDefaultButton.Button2); // Default para "Não" (botão 2)

            if (confirmacao == DialogResult.Yes)
            {
                var estadoController = new EstadoController();

                // Excluir do banco e do grid
                if (estadoController.ExcluirEstado(estadoSelecionado))
                {
                    dgv_estados.Rows.Remove(dgv_estados.CurrentRow);

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_estados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoAcao = "alteracao";
            alterarDados();
        }

        private void dgv_estados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(vid, out int idSelecionado))
                {
                    EstadoController estadoController = new EstadoController();
                    Estados estadoSelecionado = estadoController.ObterEstadoPorId(idSelecionado);

                    if (estadoSelecionado != null)
                    {
                        tb_id.Text = estadoSelecionado.Id.ToString();
                        tb_sigla.Text = estadoSelecionado.Sigla;
                        tb_descricao.Text = estadoSelecionado.Descricao;
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
            tb_sigla.Enabled = false;
            tb_descricao.Enabled = false;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;

            if (tipoAcao == "alteracao")
            {
                idSelecionado = dgv_estados.Rows[0].Cells[0].Value.ToString();
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
            tb_id.Text = Globais.gerarNovoID("tbestados").ToString();
            tb_sigla.Clear();
            tb_descricao.Clear();
            tipoAcao = "inclusao";
            alterarDados();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tipoAcao == "alteracao")
            {
                try
                {
                    Estados estado = new Estados
                    {
                        Id = int.Parse(tb_id.Text),
                        Sigla = tb_sigla.Text,
                        Descricao = tb_descricao.Text,
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
                }
                tbc_control.SelectedTab = tbp_lista;
                tb_sigla.Enabled = false;
                tb_descricao.Enabled = false;
                btn_gravar.Enabled = false;
                btn_cancelar.Enabled = false;
            }
            else if (tipoAcao == "inclusao")
            {
                try
                {
                    Estados novoEstado = new Estados
                    {
                        Sigla = tb_sigla.Text,
                        Descricao = tb_descricao.Text
                    };

                    EstadoController estadoController = new EstadoController();
                    bool sucesso = estadoController.InserirEstados(novoEstado);

                    if (sucesso)
                    {
                        // limpa o formulário
                        LimparFormulario();

                        // Atualiza lista do formulário
                        carregarGrid();

                        //Gera novo id após cadastro de usuario
                        tb_id.Text = Globais.gerarNovoID("tbestados").ToString();

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
