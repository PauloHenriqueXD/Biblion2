using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.Entities
{
    public class Estados
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        // Construtor sem parâmetros
        public Estados() { }

        // Construtor com parâmetros
        public Estados(int id, string sigla, string descricao)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
        }
    }
}
