using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SQLiteCommand cmd = new SQLiteCommand();
        Conexao conexao = new Conexao();
        SQLiteDataReader dr;

        public bool verificarLogin(string login, string senha)
        {
            //procurar no banco esse login e senha
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM tbusuarios WHERE login = @login AND senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                // Usando SQLiteCommand para o SQLite
                cmd.Connection = conexao.conectar(); // Método para conectar ao SQLite
                dr = cmd.ExecuteReader(); // Executa o leitor no SQLite
                if (dr.HasRows)
                {
                    tem = true; // Define a variável como verdadeira se houver resultados
                }
            }
            catch (SQLiteException ex)
            {
                this.mensagem = "Erro com o Banco de dados!" + ex.Message;
            }
            return tem;
        }

        public string cadastrar(string email, string senha, string confSenha)
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
