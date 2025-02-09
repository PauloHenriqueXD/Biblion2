using Biblion.Entities;
using Biblion.Services;
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
    public partial class F_ImportaCidades : Form
    {
        public F_ImportaCidades()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_ImportaCidades_Load(object sender, EventArgs e)
        {
            // Cria uma instância do controlador de estados
            EstadoController estadoController = new EstadoController();

            // Obtém a lista de estados cadastrados no banco
            List<Estados> estados = estadoController.ObterEstados();

            // Configura o CheckedListBox para exibir o nome do estado (Descrição) 
            // e utilizar a sigla como valor
            checkedListBoxEstados.DataSource = estados;
            checkedListBoxEstados.DisplayMember = "Descricao";  // Exibe o nome/descrição do estado
            checkedListBoxEstados.ValueMember = "Sigla";          // Valor: a sigla (UF)
        }

        private async void btn_importar_Click(object sender, EventArgs e)
        {
            // Cria uma instância do serviço de cidades
            CidadeService cidadeService = new CidadeService();

            // Inicializa a progress bar
            progressBarImportacao.Minimum = 0;
            progressBarImportacao.Maximum = 100;
            progressBarImportacao.Value = 0;

            // Cria um progress reporter que atualiza a progress bar
            Progress<int> progressReporter = new Progress<int>(value =>
            {
                progressBarImportacao.Value = value;
            });

            // Para cada item selecionado no CheckedListBox
            foreach (var item in checkedListBoxEstados.CheckedItems)
            {
                // Converte o item para o tipo 'Estados'
                Estados estado = item as Estados;
                if (estado != null)
                {
                    // Chama a função de importação passando a sigla do estado (UF)
                    await cidadeService.AtualizarCidades(estado.Sigla, progressReporter);
                }
            }
            MessageBox.Show("Importação de cidades concluída!");
        }
    }
}
