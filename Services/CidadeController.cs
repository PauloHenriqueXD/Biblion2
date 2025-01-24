using Biblion.DAL;
using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data; // Para DataTable
using System.IO;
using System.Windows.Forms; // Para o DataGridView

public class CidadeController
{
    private Conexao conexao;

    public CidadeController()
    {
        conexao = new Conexao(); // Supondo que você já tenha a classe Conexao implementada
    }

    public List<Cidades> ObterCidade()
    {
        List<Cidades> cidades = new List<Cidades>();

        try
        {
            string query = "SELECT id, descricao, codMunicipio, uf FROM tbcidades";

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
                        Cidades cidade = new Cidades
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Descricao = reader["descricao"].ToString(),
                            codMunicipio = Convert.ToInt32(reader["codMunicipio"]),
                            Uf = reader["uf"].ToString()
                        };

                        cidades.Add(cidade);
                    }
                } // O reader será fechado automaticamente aqui
            } // A conexão será fechada automaticamente aqui, ao sair do bloco 'using'
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar usuários: " + ex.Message);
        }

        return cidades;
    }

    public void PreencherDataGridView(DataGridView grid)
    {
        var cidades = ObterCidade();

        // Converte a lista para um DataTable (opcional, mas recomendado para grids)
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Descrição", typeof(string));
        table.Columns.Add("Cod. Município", typeof(int));
        table.Columns.Add("UF", typeof(string));

        foreach (var cidade in cidades)
        {
            table.Rows.Add(cidade.Id, cidade.Descricao, cidade.codMunicipio, cidade.Uf);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public List<Cidades> FiltrarCidades(string termo)
    {
        List<Cidades> cidades = new List<Cidades>();

        try
        {
            // Define a consulta SQL
            string query = "SELECT id, descricao, codMunicipio, uf " +
                           "FROM tbcidades " +
                           "WHERE (descricao LIKE @Termo OR codMunicipio LIKE @Termo OR uf LIKE @Termo)";

            using (var command = conexao.CriarComando(query))
            {
                command.Parameters.AddWithValue("@Termo", $"%{termo}%");

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cidades cidade = new Cidades
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Descricao = reader["Descrição"].ToString(),
                        codMunicipio = Convert.ToInt32(reader["Cod. Município"]),
                        Uf = reader["UF"].ToString()
                    };

                    cidades.Add(cidade);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao filtrar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return cidades;
    }

    public void AtualizarDataGridView(DataGridView grid, List<Cidades> cidades)
    {
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Descrição", typeof(string));
        table.Columns.Add("Cod. Município", typeof(int));
        table.Columns.Add("UF", typeof(string));

        foreach (var cidade in cidades)
        {
            table.Rows.Add(cidade.Id, cidade.Descricao, cidade.codMunicipio, cidade.Uf);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public bool ExcluirCidade(Cidades cidade)
    {
        if (cidade == null || cidade.Id <= 0)
            throw new ArgumentException("Registro inválido para exclusão.");

        try
        {
            // Usando o bloco using para garantir que a conexão será fechada automaticamente
            using (var conexao = new Conexao())
            {
                string query = "DELETE FROM tbcidades WHERE id = @Id";
                var command = conexao.CriarComando(query);
                command.Parameters.AddWithValue("@Id", cidade.Id);

                conexao.Conectar(); // Certifica-se de que a conexão está aberta
                int linhasAfetadas = command.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
        }
        catch (Exception ex)
        {
            // Lidar com o erro (log ou mensagem ao Registro)
            MessageBox.Show($"Erro ao excluir Registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public Cidades ObterCidadePorId(int id)
    {
        Cidades cidade = null;

        try
        {
            string query = "SELECT id, descricao, codMunicipio, uf FROM tbcidades WHERE id = @id";

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
                            cidade = new Cidades
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Descricao = reader["descricao"].ToString(),
                                codMunicipio = Convert.ToInt32(reader["codMunicipio"]),
                                Uf = reader["uf"].ToString()
                            };
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao obter dados do Registro: {ex.Message}");
        }

        return cidade;
    }

    public void AtualizarCidade(Cidades cidade)
    {
        try
        {
            // Atualiza o banco de dados
            using (var conexao = new Conexao())
            {
                string query = "UPDATE tbcidade SET descricao = @descricao, codMunicipio = #codMunicipio, uf = @uf WHERE id = @id";
                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@descricao", cidade.Descricao);
                    comando.Parameters.AddWithValue("@codMunicipio", cidade.codMunicipio);
                    comando.Parameters.AddWithValue("@uf", cidade.Uf);
                    comando.Parameters.AddWithValue("@id", cidade.Id);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registro atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar o Registro: {ex.Message}");
        }
    }

    public bool InserirCidades(Cidades cidade)
    {
        bool sucesso = false;

        try
        {
            // Insere os dados no banco de dados
            using (var conexao = new Conexao())
            {
                string query = @"
                INSERT INTO tbcidades (guid, id, descricao, codMunicipio, uf)
                VALUES (@guid, @id, @descricao, @codMunicipio, @uf)";

                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@guid", Guid.NewGuid().ToString());
                    comando.Parameters.AddWithValue("@id", Globais.gerarNovoID("tbcidades"));
                    comando.Parameters.AddWithValue("@descricao", cidade.Descricao);
                    comando.Parameters.AddWithValue("@codMunicipio", cidade.codMunicipio);
                    comando.Parameters.AddWithValue("@uf", cidade.Uf);

                    comando.ExecuteNonQuery();
                    sucesso = true;
                }
            }

            MessageBox.Show("Registro cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar o Registro: {ex.Message}");
        }

        return sucesso;
    }

}//Fim CidadeController
