using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.Entities
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int codMunicipio { get; set; }
        public string Uf { get; set; }

        // Construtor sem parâmetros
        public Cidades() { }

        // Construtor com parâmetros
        public Cidades(int id, string descricao, int codMunicipio, string uf)
        {
            Id = id;
            Descricao = descricao;
            this.codMunicipio = codMunicipio;
            Uf = uf;
        }
    }
}
