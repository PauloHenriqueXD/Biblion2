using Biblion.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Biblion.Services
{
    public class EstadoService
    {
        private static readonly HttpClient client = new HttpClient();
        private EstadoController controller = new EstadoController();

        public async Task<List<Estados>> ObterEstadosDaAPI()
        {
            string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
            string responseString = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Estados>>(responseString);
        }

        public async Task AtualizarEstados()
        {
            List<Estados> estadosAPI = await ObterEstadosDaAPI();
            List<Estados> estadosCadastrados = controller.ObterEstados();
            HashSet<string> siglasCadastradas = new HashSet<string>(estadosCadastrados.ConvertAll(e => e.Sigla));

            foreach (var estado in estadosAPI)
            {
                if (!siglasCadastradas.Contains(estado.Sigla))
                {
                    controller.InserirEstados(estado);
                    Console.WriteLine($"Estado {estado.Descricao} cadastrado.");
                }
            }

        }
    }
}
