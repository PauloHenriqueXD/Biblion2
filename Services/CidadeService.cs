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
    public class CidadeService
    {
        private static readonly HttpClient client = new HttpClient();
        private CidadeController controller = new CidadeController();

        public async Task<List<Cidades>> ObterMunicipiosDaAPI(string uf)
        {
            string url = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/municipios";
            string responseString = await client.GetStringAsync(url);
            List<Cidades> cidades = JsonConvert.DeserializeObject<List<Cidades>>(responseString);
            // Define o UF manualmente para cada cidade importada
            foreach (var cidade in cidades)
            {
                cidade.Uf = uf;
            }
            return cidades;
        }

        /// <summary>
        /// Atualiza (importa) as cidades de um determinado estado, reportando o progresso.
        /// </summary>
        /// <param name="uf">A sigla do estado (UF) para importação.</param>
        /// <param name="progress">Interface para reportar o progresso (valor de 0 a 100).</param>
        public async Task AtualizarCidades(string uf, IProgress<int> progress)
        {
            List<Cidades> cidadesAPI = await ObterMunicipiosDaAPI(uf);
            List<Cidades> cidadesCadastradas = controller.ObterCidade();
            HashSet<int> codMunicipiosCadastrados = new HashSet<int>(cidadesCadastradas.ConvertAll(c => c.codMunicipio));

            int total = cidadesAPI.Count;
            int processed = 0;

            foreach (var cidade in cidadesAPI)
            {
                // Se a cidade (identificada pelo código do município) ainda não estiver cadastrada, insere-a
                if (!codMunicipiosCadastrados.Contains(cidade.codMunicipio))
                {
                    controller.InserirCidades(cidade);
                    Console.WriteLine($"Cidade {cidade.Descricao} cadastrada.");
                }
                processed++;

                // Calcula o percentual concluído e reporta
                int percent = (int)((double)processed / total * 100);
                progress?.Report(percent);
            }
        }
    }
}