using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.Entities
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public int Acesso { get; set; }
        public string Img { get; set; }

        // Construtor sem parâmetros
        public Usuarios() { }

        // Construtor com parâmetros
        public Usuarios(int id, string nome, string login, string senha, string status, int acesso, string img)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
            Status = status;
            Acesso = acesso;
            Img = img;
        }




    }
}
