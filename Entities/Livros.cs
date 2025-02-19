using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.Entities
{
    public class Livros
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public string Editora { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public string Descricao { get; set; }
        public int NumeroPaginas { get; set; }
        public string Categoria { get; set; }
        public string Idioma { get; set; }
        public string UrlCapa { get; set; }
        public string Status { get; set; }

        // Construtor sem parâmetros
        public Livros() { }

        // Construtor com parâmetros
        public Livros(int id, string iSBN, string titulo, string autores, string editora, DateTime dataPublicacao, string descricao, int numeroPaginas, string categoria, string idioma, string urlCapa, string status)
        {
            Id = id;
            ISBN = iSBN;
            Titulo = titulo;
            Autores = autores;
            Editora = editora;
            DataPublicacao = dataPublicacao;
            Descricao = descricao;
            NumeroPaginas = numeroPaginas;
            Categoria = categoria;
            Idioma = idioma;
            UrlCapa = urlCapa;
            Status = status;
        }


    }
}
