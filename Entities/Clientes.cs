using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.Entities
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Status { get; set; }
        public string Sexo { get; set; }
        public string Documento { get; set; }
        public string Datanasc { get; set; }
        public string Uf { get; set; }
        public int CodMunicipio { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }

        // Construtor sem parâmetros
        public Clientes() { }

        // Construtor com parâmetros
        public Clientes(int id, string nome, string email, string telefone, string status, string sexo, string documento, string datanasc, string uf, int codMunicipio, string bairro, string endereco, int numero)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Status = status;
            Sexo = sexo;
            Documento = documento;
            Datanasc = datanasc;
            Uf = uf;
            CodMunicipio = codMunicipio;
            Bairro = bairro;
            Endereco = endereco;
            Numero = numero;
        }
    }
}
