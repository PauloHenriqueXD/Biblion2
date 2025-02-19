using Biblion.DAL;
using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

public class LivroController
{
    private Conexao conexao;

    public LivroController()
    {
        conexao = new Conexao(); // Supondo que você já tenha a classe Conexao implementada
    }

    public List<Livros> ObterLivros()
    {
        List<Livros> livros = new List<Livros>();

        try
        {
            string query = "SELECT id, isbn, titulo, autores, editora, data_publicacao, descricao, numero_paginas, categoria, idioma, url_capa, status FROM tblivros";

            // Abre a conexão
            using (var conexao = new Conexao()) // Usando 'using' para garantir o fechamento adequado da conexão
            {
                // Conectar à base de dados
                conexao.Conectar();

                // Criar o comando e associar à conexão
                var command = conexao.CriarComando(query);

                // Executar o leitor de dados
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Livros livro = new Livros
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            ISBN = reader["isbn"].ToString(),
                            Titulo = reader["titulo"].ToString(),
                            Autores = reader["autores"].ToString(),
                            Editora = reader["editora"].ToString(),
                            DataPublicacao = Convert.ToDateTime(reader["data_publicacao"].ToString()),
                            Descricao = reader["descricao"].ToString(),
                            NumeroPaginas = Convert.ToInt32(reader["numero_paginas"]),
                            Categoria = reader["categoria"].ToString(),
                            Idioma = reader["idioma"].ToString(),
                            UrlCapa = reader["url_capa"].ToString(),
                            Status = reader["status"].ToString()
                        };

                        livros.Add(livro);
                    }
                } // O reader será fechado automaticamente aqui
            } // A conexão será fechada automaticamente aqui, ao sair do bloco 'using'
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar Livro: " + ex.Message);
        }

        return livros;
    }

    public void PreencherDataGridView(DataGridView grid)
    {
        var livros = ObterLivros();

        // Converte a lista para um DataTable (opcional, mas recomendado para grids)
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("ISBN", typeof(string));
        table.Columns.Add("Título", typeof(string));
        table.Columns.Add("Autores", typeof(string));
        table.Columns.Add("Data da Publicação", typeof(string));
        table.Columns.Add("Status", typeof(int));

        foreach (var livro in livros)
        {
            table.Rows.Add(livro.Id, livro.ISBN, livro.Titulo, livro.Autores, livro.DataPublicacao, livro.Status);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public List<Livros> FiltrarLivros(string termo, string status)
    {
        List<Livros> livros = new List<Livros>();

        try
        {
            // Define a consulta SQL
            string query = "SELECT id, isbn, titulo, autores, editora, data_publicacao, descricao, numero_paginas, categoria, idioma, url_capa, status " +
                           "FROM tblivros " +
                           "WHERE (titulo LIKE @Termo OR autores LIKE @Termo OR editora LIKE @Termo OR categoria LIKE @Termo)";

            // Adiciona o filtro de status, exceto quando for "Todos" (T)
            if (status != "T")
            {
                query += " AND status = @Status";
            }

            using (var command = conexao.CriarComando(query))
            {
                command.Parameters.AddWithValue("@Termo", $"%{termo}%");

                if (status != "T")
                {
                    command.Parameters.AddWithValue("@Status", status);
                }

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Livros livro = new Livros
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        ISBN = reader["isbn"].ToString(),
                        Titulo = reader["titulo"].ToString(),
                        Autores = reader["autores"].ToString(),
                        Editora = reader["editora"].ToString(),
                        DataPublicacao = Convert.ToDateTime(reader["data_publicacao"].ToString()),
                        Descricao = reader["descricao"].ToString(),
                        NumeroPaginas = Convert.ToInt32(reader["numero_paginas"]),
                        Categoria = reader["categoria"].ToString(),
                        Idioma = reader["idioma"].ToString(),
                        UrlCapa = reader["url_capa"].ToString(),
                        Status = reader["status"].ToString()
                    };

                    livros.Add(livro);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao filtrar Livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return livros;
    }

    public void AtualizarDataGridView(DataGridView grid, List<Livros> livros)
    {
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("ISBN", typeof(string));
        table.Columns.Add("Título", typeof(string));
        table.Columns.Add("Autores", typeof(string));
        table.Columns.Add("Data da Publicação", typeof(DateTime));
        table.Columns.Add("Status", typeof(string));

        foreach (var livro in livros)
        {
            table.Rows.Add(livro.Id, livro.ISBN, livro.Titulo, livro.Autores, livro.DataPublicacao.HasValue ? livro.DataPublicacao.Value : (object)DBNull.Value, livro.Status);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public bool ExcluirLivros(Livros livros)
    {
        if (livros == null || livros.Id <= 0)
            throw new ArgumentException("Livro inválido para exclusão.");

        try
        {
            // Recupera o caminho atual da imagem do banco de dados
            string caminhoImagem = "";
            using (var conexao = new Conexao())
            {
                string queryBusca = "SELECT url_capa FROM tblivros WHERE id = @id";
                using (var comandoBusca = conexao.CriarComando(queryBusca))
                {
                    comandoBusca.Parameters.AddWithValue("@id", livros.Id);
                    var reader = comandoBusca.ExecuteReader();

                    if (reader.Read())
                    {
                        caminhoImagem = reader["url_capa"].ToString(); // Obtém o caminho da imagem do banco
                    }

                    reader.Close();
                }
            }

            // Exclui a imagem da pasta do sistema
            if (!string.IsNullOrEmpty(caminhoImagem))
            {
                string caminhoCompletoImagemAntiga = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoImagem);

                if (File.Exists(caminhoCompletoImagemAntiga))
                {
                    File.Delete(caminhoCompletoImagemAntiga);
                }
            }

            // Usando o bloco using para garantir que a conexão será fechada automaticamente
            using (var conexao = new Conexao())
            {
                string query = "DELETE FROM tblivros WHERE id = @Id";
                var command = conexao.CriarComando(query);
                command.Parameters.AddWithValue("@Id", livros.Id);

                conexao.Conectar(); // Certifica-se de que a conexão está aberta
                int linhasAfetadas = command.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
        }
        catch (Exception ex)
        {
            // Lidar com o erro (log ou mensagem)
            MessageBox.Show($"Erro ao excluir Livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public Livros ObterLivrosPorId(int id)
    {
        Livros livro = null;

        try
        {
            string query = "SELECT id, isbn, titulo, autores, editora, data_publicacao, descricao, numero_paginas, categoria, idioma, url_capa, status FROM tblivros WHERE id = @id";

            using (var conexao = new Conexao())
            {
                conexao.Conectar();

                using (var cmd = conexao.CriarComando(query))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            livro = new Livros
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                ISBN = reader["isbn"].ToString(),
                                Titulo = reader["titulo"].ToString(),
                                Autores = reader["autores"].ToString(),
                                Editora = reader["editora"].ToString(),
                                DataPublicacao = Convert.ToDateTime(reader["data_publicacao"].ToString()),
                                Descricao = reader["descricao"].ToString(),
                                NumeroPaginas = Convert.ToInt32(reader["numero_paginas"]),
                                Categoria = reader["categoria"].ToString(),
                                Idioma = reader["idioma"].ToString(),
                                UrlCapa = reader["url_capa"].ToString(),
                                Status = reader["status"].ToString()
                            };
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao obter dados do Livro: {ex.Message}");
        }

        return livro;
    }

    public void AtualizarLivros(Livros livro, string caminhoImagemSelecionada)
    {
        try
        {
            string pastaImg = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");

            // Garante que a pasta "img" existe
            if (!Directory.Exists(pastaImg))
            {
                Directory.CreateDirectory(pastaImg);
            }

            string caminhoImagemAntiga = "";

            // Recupera o caminho atual da imagem do banco de dados
            using (var conexao = new Conexao())
            {
                string queryBusca = "SELECT url_capa FROM tblivros WHERE id = @id";
                using (var comandoBusca = conexao.CriarComando(queryBusca))
                {
                    comandoBusca.Parameters.AddWithValue("@id", livro.Id);
                    var reader = comandoBusca.ExecuteReader();

                    if (reader.Read())
                    {
                        caminhoImagemAntiga = reader["img"].ToString(); // Obtém o caminho da imagem do banco
                    }

                    reader.Close();
                }
            }

            //MessageBox.Show(caminhoImagemAntiga);

            // Verifica se uma nova imagem foi selecionada
            if (!string.IsNullOrEmpty(caminhoImagemSelecionada))
            {
                // Gera um nome único para a nova imagem
                string nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(caminhoImagemSelecionada);
                string novoCaminhoImagem = Path.Combine(pastaImg, nomeArquivo);

                // Copia a nova imagem para a pasta "img"
                File.Copy(caminhoImagemSelecionada, novoCaminhoImagem, true);

                // Exclui a imagem antiga da pasta do sistema
                if (!string.IsNullOrEmpty(caminhoImagemAntiga))
                {
                    string caminhoCompletoImagemAntiga = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, caminhoImagemAntiga);

                    if (File.Exists(caminhoCompletoImagemAntiga))
                    {
                        File.Delete(caminhoCompletoImagemAntiga);
                    }
                }

                // Atualiza o caminho completo da nova imagem no objeto
                livro.UrlCapa = novoCaminhoImagem; // Salva o caminho completo
            }

            // Atualiza o banco de dados
            using (var conexao = new Conexao())
            {
                string query = "UPDATE tblivros SET isbn = @isbn, titulo = @titulo, autores = @autores, editora = @editora, data_publicacao = @data_publicacao, descricao = @descricao, numero_paginas = @numero_paginas, categoria = @categoria, idioma = @idioma, url_capa = @url_capa, status = @status WHERE id = @id";
                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@isbn", livro.ISBN);
                    comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                    comando.Parameters.AddWithValue("@autores", livro.Autores);
                    comando.Parameters.AddWithValue("@editora", livro.Editora);
                    comando.Parameters.AddWithValue("@data_publicacao", livro.DataPublicacao);
                    comando.Parameters.AddWithValue("@descricao", livro.Descricao);
                    comando.Parameters.AddWithValue("@numero_paginas", livro.NumeroPaginas);
                    comando.Parameters.AddWithValue("@categoria", livro.Categoria);
                    comando.Parameters.AddWithValue("@idioma", livro.Idioma);
                    comando.Parameters.AddWithValue("@url_capa", livro.UrlCapa);
                    comando.Parameters.AddWithValue("@status", livro.Status);
                    comando.Parameters.AddWithValue("@id", livro.Id);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Livro atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar o Livro: {ex.Message}");
        }
    }

    public bool InserirLivros(Livros livro)
    {
        bool sucesso = false;

        try
        {
            // Caminho para a pasta "img"
            string pastaImg = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");

            // Garante que a pasta "img" existe
            if (!Directory.Exists(pastaImg))
            {
                Directory.CreateDirectory(pastaImg);
            }

            // Copia a imagem para a pasta "img" caso tenha sido fornecida
            if (!string.IsNullOrEmpty(livro.UrlCapa))
            {
                string nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(livro.UrlCapa);
                string caminhoCompletoImagem = Path.Combine(pastaImg, nomeArquivo);

                File.Copy(livro.UrlCapa, caminhoCompletoImagem, true);

                // Atualiza o caminho no objeto usuário
                livro.UrlCapa = caminhoCompletoImagem;
            }

            // Insere os dados no banco de dados
            using (var conexao = new Conexao())
            {
                string query = @"
                INSERT INTO tblivros 
                (guid, id, isbn, titulo, autores, editora, data_publicacao, descricao, numero_paginas, categoria, idioma, url_capa, status)
                VALUES 
                (@guid, @id, @isbn, @titulo, @autores, @editora, @data_publicacao, @descricao, @numero_paginas, @categoria, @idioma, @url_capa, @status)";

                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@guid", Guid.NewGuid().ToString());
                    comando.Parameters.AddWithValue("@id", Globais.gerarNovoID("tblivros"));
                    comando.Parameters.AddWithValue("@isbn", livro.ISBN);
                    comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                    comando.Parameters.AddWithValue("@autores", livro.Autores);
                    comando.Parameters.AddWithValue("@editora", livro.Editora);
                    comando.Parameters.AddWithValue("@data_publicacao", livro.DataPublicacao);
                    comando.Parameters.AddWithValue("@descricao", livro.Descricao);
                    comando.Parameters.AddWithValue("@numero_paginas", livro.NumeroPaginas);
                    comando.Parameters.AddWithValue("@categoria", livro.Categoria);
                    comando.Parameters.AddWithValue("@idioma", livro.Idioma);
                    comando.Parameters.AddWithValue("@url_capa", livro.UrlCapa);
                    comando.Parameters.AddWithValue("@status", livro.Status);

                    comando.ExecuteNonQuery();
                    sucesso = true;
                }
            }

            MessageBox.Show("Livro cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar Livro: {ex.Message}");
        }

        return sucesso;
    }
}
