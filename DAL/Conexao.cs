using Biblion.Entities;
using System;
using System.Data.SQLite;

namespace Biblion.DAL
{
    class Conexao : IDisposable
    {
        private SQLiteConnection conexao; // A conexão será gerenciada pelo IDisposable
        private bool disposedValue = false; // Variável para evitar chamadas duplicadas ao Dispose

        public Conexao()
        {
            // Inicializando a conexão com o banco de dados
            string stringConexao = "Data Source=" + Globais.caminhoBanco + Globais.nomeBanco;
            conexao = new SQLiteConnection(stringConexao);
        }

        // Método para abrir a conexão
        public SQLiteConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        // Método para fechar a conexão
        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        // Método para executar comandos e retornar um SQLiteDataReader
        public SQLiteDataReader ExecutarReader(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conexao);
            return cmd.ExecuteReader(); // O reader será gerenciado pelo chamador
        }

        // Método para criar comandos de SQL
        public SQLiteCommand CriarComando(string query)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }
            return new SQLiteCommand(query, conexao);
        }

        // Implementando IDisposable para gerenciar a conexão corretamente
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Liberando os recursos gerenciados
                    if (conexao != null)
                    {
                        if (conexao.State == System.Data.ConnectionState.Open)
                        {
                            conexao.Close();
                        }
                        conexao.Dispose();
                        conexao = null;
                    }
                }

                // Liberando recursos não gerenciados (não necessário aqui)
                disposedValue = true;
            }
        }

        // Método público para liberar recursos
        public void Dispose()
        {
            // Não chamar Dispose mais de uma vez
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
