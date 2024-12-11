using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblion.DAL
{
    class Conexao
    {
        SQLiteConnection conexao = new SQLiteConnection();

        public Conexao()
        {
            conexao = new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
        }

        public SQLiteConnection conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
