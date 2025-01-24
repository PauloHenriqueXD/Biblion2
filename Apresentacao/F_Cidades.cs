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
    public partial class F_Cidades : Form
    {
        public F_Cidades()
        {
            InitializeComponent();
            cidadeController = new CidadeController(); // Inicializa o controller
            estadoController = new EstadoController(); // Inicializa o controller Estados
        }

        private CidadeController cidadeController;
        private EstadoController estadoController;
        private string idSelecionado = "";
        private string tipoAcao = "";

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_primeiro_Click(object sender, EventArgs e)
        {
            Globais.primeiro(dgv_cidades);
        }

        private void tsb_anterior_Click(object sender, EventArgs e)
        {
            Globais.anterior(dgv_cidades);
        }

        private void tsb_proximo_Click(object sender, EventArgs e)
        {
            Globais.proximo(dgv_cidades);
        }

        private void tsb_ultimo_Click(object sender, EventArgs e)
        {
            Globais.ultimo(dgv_cidades);
        }

        private string contaResultados()
        {
            //Função para pegar resultados de um grid e informar em um lb
            string resultados = dgv_cidades.Rows.Count.ToString();
            return lb_registros.Text = resultados + " Regs";
        }

        private void alterarDados()
        {
            tbc_control.SelectedTab = tbp_dados;
            cb_estados.Enabled = true;
            tb_cidade.Enabled = true;
            tb_codMunicipio.Enabled = true;
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void carregarGrid()
        {
            try
            {
                // Inicializa o controlador responsável pelas Cidades
                cidadeController = new CidadeController();

                // Popula o DataGridView com os dados da tabela Cidades
                cidadeController.PreencherDataGridView(dgv_cidades);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Definindo tamanho da DataGridView
                dgv_cidades.Columns[0].Width = (int)(dgv_cidades.Width * 0.1);
                dgv_cidades.Columns[1].Width = (int)(dgv_cidades.Width * 0.4);
                dgv_cidades.Columns[2].Width = (int)(dgv_cidades.Width * 0.2);
                dgv_cidades.Columns[3].Width = (int)(dgv_cidades.Width * 0.15);

                idSelecionado = dgv_cidades.Columns[0].ToString();
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
                var cidadesFiltrados = cidadeController.FiltrarCidades(termo);

                // Atualiza o DataGridView
                cidadeController.AtualizarDataGridView(dgv_cidades, cidadesFiltrados);

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
            cb_estados.SelectedIndex = 0;
            tb_cidade.Clear();
            tb_codMunicipio.Clear();
        }

        private void F_Cidades_Load(object sender, EventArgs e)
        {

            try
            {
                // Carregar os estados no ComboBox
                List<Estados> estados = estadoController.ObterEstados();
                cb_estados.DataSource = estados;
                cb_estados.DisplayMember = "Descricao";
                cb_estados.ValueMember = "Id";

                carregarGrid();

                if (dgv_cidades.Rows.Count > 0)
                {
                    idSelecionado = dgv_cidades.Rows[0].Cells[0].Value.ToString();
                    dgv_cidades.CurrentCell = dgv_cidades.Rows[0].Cells[0];
                    dgv_cidades.Rows[0].Selected = true;
                }
                else
                {
                    idSelecionado = string.Empty;
                }

                dgv_cidades.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar ComboBox Estados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Carregando dados na Grid
            carregarGrid();

            // Verificar se existem linhas na grid
            if (dgv_cidades.Rows.Count > 0)
            {
                idSelecionado = dgv_cidades.Rows[0].Cells[0].Value.ToString();
                // Selecionar a primeira linha
                dgv_cidades.CurrentCell = dgv_cidades.Rows[0].Cells[0];
                dgv_cidades.Rows[0].Selected = true;
            }

            // Adicionar o foco à grid
            dgv_cidades.Focus();

        }

        private void tb_filtroNome_TextChanged(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void tbc_control_KeyDown(object sender, KeyEventArgs e)
        {
            int tecla = e.KeyValue;
            switch (tecla)
            {
                case 40: //baixo
                    Globais.proximo(dgv_cidades);
                    break;
                case 38: //cima
                    Globais.anterior(dgv_cidades);
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

        private void F_Cidades_Shown(object sender, EventArgs e)
        {
            dgv_cidades.Focus();
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            // Verifica se tem algum Registro Selecionado para Excluir, caso não avisa
            if (dgv_cidades.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o registro da linha selecionada
            var cidadeSelecionado = new Cidades
            {
                Id = Convert.ToInt32(dgv_cidades.CurrentRow.Cells["Id"].Value),
                Descricao = dgv_cidades.CurrentRow.Cells["Descrição"].Value.ToString(),
                codMunicipio = Convert.ToInt32(dgv_cidades.CurrentRow.Cells["Cod. Município"].Value),
                Uf = dgv_cidades.CurrentRow.Cells["UF"].Value.ToString()
            };

            // Confirmação do usuário
            var confirmacao = MessageBox.Show($"Tem certeza de que deseja excluir o Registro {cidadeSelecionado.Descricao}?",
                                              "Confirmar Exclusão",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning, // Ícone de alerta
                                              MessageBoxDefaultButton.Button2); // Default para "Não" (botão 2)

            if (confirmacao == DialogResult.Yes)
            {
                var cidadeController = new CidadeController();

                // Excluir do banco e do grid
                if (cidadeController.ExcluirCidade(cidadeSelecionado))
                {
                    dgv_cidades.Rows.Remove(dgv_cidades.CurrentRow);

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_cidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoAcao = "alteracao";
            alterarDados();
        }

        private void dgv_cidades_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(vid, out int idSelecionado))
                {
                    CidadeController cidadeController = new CidadeController();
                    Cidades cidadeSelecionado = cidadeController.ObterCidadePorId(idSelecionado);

                    if (cidadeSelecionado != null)
                    {
                        tb_id.Text = cidadeSelecionado.Id.ToString();
                        tb_cidade.Text = cidadeSelecionado.Descricao;
                        tb_codMunicipio.Text = cidadeSelecionado.codMunicipio.ToString();
                        cb_estados.Text = cidadeSelecionado.Uf;
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
            cb_estados.Enabled = false;
            tb_cidade.Enabled = false;
            tb_codMunicipio.Enabled = false;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;

            if (tipoAcao == "alteracao")
            {
                idSelecionado = dgv_cidades.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                carregarGrid();
            }

            tipoAcao = "";

        }

        private void tsb_incluir_Click(object sender, EventArgs e)
        {
            //Corrigindo campos após Cadastro
            tb_id.Text = Globais.gerarNovoID("tbcidades").ToString();
            tb_cidade.Clear();
            cb_estados.SelectedIndex = 0;
            tb_codMunicipio.Clear();
            tipoAcao = "inclusao";
            alterarDados();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tipoAcao == "alteracao")
            {
                try
                {
                    Cidades cidade = new Cidades
                    {
                        Id = int.Parse(tb_id.Text),
                        Descricao = tb_cidade.Text,
                        codMunicipio = int.Parse(tb_codMunicipio.Text),
                        Uf = cb_estados.Text
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
                }
                tbc_control.SelectedTab = tbp_lista;
                tb_cidade.Enabled = false;
                cb_estados.Enabled = false;
                tb_codMunicipio.Enabled = false;
                btn_gravar.Enabled = false;
                btn_cancelar.Enabled = false;
            }
            else if (tipoAcao == "inclusao")
            {
                try
                {
                    Cidades novaCidade = new Cidades
                    {
                        Descricao = tb_cidade.Text,
                        Uf = cb_estados.SelectedText,
                        codMunicipio = int.Parse(tb_codMunicipio.Text)
                    };

                    CidadeController cidadeController = new CidadeController();
                    bool sucesso = cidadeController.InserirCidades(novaCidade);

                    if (sucesso)
                    {
                        // limpa o formulário
                        LimparFormulario();

                        // Atualiza lista do formulário
                        carregarGrid();

                        //Gera novo id após cadastro de cidade
                        tb_id.Text = Globais.gerarNovoID("tbcidades").ToString();

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
