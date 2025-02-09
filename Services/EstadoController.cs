using Biblion.DAL;
using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data; // Para DataTable
using System.IO;
using System.Windows.Forms; // Para o DataGridView

public class EstadoController
{
    private Conexao conexao;

    public EstadoController()
    {
        conexao = new Conexao(); // Supondo que você já tenha a classe Conexao implementada
    }

    public List<Estados> ObterEstados()
    {
        List<Estados> estados = new List<Estados>();

        try
        {
            string query = "SELECT id, sigla, descricao FROM tbestados";

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
                        Estados estado = new Estados
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Sigla = reader["sigla"].ToString(),
                            Descricao = reader["descricao"].ToString()
                        };

                        estados.Add(estado);
                    }
                } // O reader será fechado automaticamente aqui
            } // A conexão será fechada automaticamente aqui, ao sair do bloco 'using'
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar usuários: " + ex.Message);
        }

        return estados;
    }

    public void PreencherDataGridView(DataGridView grid)
    {
        var estados = ObterEstados();

        // Converte a lista para um DataTable (opcional, mas recomendado para grids)
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Sigla", typeof(string));
        table.Columns.Add("Descrição", typeof(string));

        foreach (var estado in estados)
        {
            table.Rows.Add(estado.Id, estado.Sigla, estado.Descricao);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public List<Estados> FiltrarEstados(string termo)
    {
        List<Estados> estados = new List<Estados>();

        try
        {
            // Define a consulta SQL
            string query = "SELECT id, sigla, descricao " +
                           "FROM tbestados " +
                           "WHERE (sigla LIKE @Termo OR descricao LIKE @Termo)";

            using (var command = conexao.CriarComando(query))
            {
                command.Parameters.AddWithValue("@Termo", $"%{termo}%");

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Estados estado = new Estados
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Sigla = reader["Sigla"].ToString(),
                        Descricao = reader["Descricao"].ToString()
                    };

                    estados.Add(estado);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao filtrar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return estados;
    }

    public void AtualizarDataGridView(DataGridView grid, List<Estados> estados)
    {
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Sigla", typeof(string));
        table.Columns.Add("Descricao", typeof(string));

        foreach (var estado in estados)
        {
            table.Rows.Add(estado.Id, estado.Sigla, estado.Descricao);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public bool ExcluirEstado(Estados estado)
    {
        if (estado == null || estado.Id <= 0)
            throw new ArgumentException("Estado inválido para exclusão.");

        try
        {
            // Usando o bloco using para garantir que a conexão será fechada automaticamente
            using (var conexao = new Conexao())
            {
                string query = "DELETE FROM tbestados WHERE id = @Id";
                var command = conexao.CriarComando(query);
                command.Parameters.AddWithValue("@Id", estado.Id);

                conexao.Conectar(); // Certifica-se de que a conexão está aberta
                int linhasAfetadas = command.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
        }
        catch (Exception ex)
        {
            // Lidar com o erro (log ou mensagem ao estado)
            MessageBox.Show($"Erro ao excluir estado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public Estados ObterEstadoPorId(int id)
    {
        Estados estado = null;

        try
        {
            string query = "SELECT id, sigla, descricao FROM tbestados WHERE id = @id";

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
                            estado = new Estados
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Sigla = reader["Sigla"].ToString(),
                                Descricao = reader["Descricao"].ToString()
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

        return estado;
    }

    public void AtualizarEstado(Estados estado)
    {
        try
        {
            //MessageBox.Show("Sigla: " + estado.Sigla + " Descrição: " + estado.Descricao + " ID: " + estado.Id);
            // Atualiza o banco de dados
            using (var conexao = new Conexao())
            {
                string query = "UPDATE tbestados SET sigla = @sigla, descricao = @descricao WHERE id = @id";
                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@sigla", estado.Sigla);
                    comando.Parameters.AddWithValue("@descricao", estado.Descricao);
                    comando.Parameters.AddWithValue("@id", estado.Id);

                    comando.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar o Estado: {ex.Message}");
        }
    }

    public bool InserirEstados(Estados estado)
    {
        bool sucesso = false;

        try
        {
            // Insere os dados no banco de dados
            using (var conexao = new Conexao())
            {
                string query = @"
                INSERT INTO tbestados (guid, id, sigla, descricao)
                VALUES (@guid, @id, @sigla, @descricao)";

                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@guid", Guid.NewGuid().ToString());
                    comando.Parameters.AddWithValue("@id", Globais.gerarNovoID("tbestados"));
                    comando.Parameters.AddWithValue("@sigla", estado.Sigla.ToUpper()); 
                    comando.Parameters.AddWithValue("@descricao", estado.Descricao.ToUpper());

                    comando.ExecuteNonQuery();
                    sucesso = true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar Estado: {ex.Message}");
        }
        return sucesso;
    }

    public List<KeyValuePair<string, string>> ComboBoxEstados()
    {
        List<KeyValuePair<string, string>> estados = new List<KeyValuePair<string, string>>();

        try
        {
            string query = "SELECT sigla, descricao FROM tbestados ORDER BY descricao";

            using (var conexao = new Conexao())
            {
                using (var comando = conexao.CriarComando(query))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string sigla = reader["sigla"].ToString();
                            string descricao = reader["descricao"].ToString();
                            estados.Add(new KeyValuePair<string, string>(sigla, descricao));
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao obter cidades: {ex.Message}");
        }

        return estados;
    }



}//Fim EstadoController
