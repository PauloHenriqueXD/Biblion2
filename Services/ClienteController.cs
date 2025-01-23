using Biblion.DAL;
using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data; // Para DataTable
using System.IO;
using System.Windows.Forms; // Para o DataGridView

public class ClienteController
{
    private Conexao conexao;

    public ClienteController()
    {
        conexao = new Conexao(); // pegando dados de conexão
    }

    public List<Clientes> ObterCliente()
    {
        List<Clientes> clientes = new List<Clientes>();

        try
        {
            string query = "SELECT id, nome, email, telefone, status, sexo, documento, datanasc, uf, cidade, bairro, endereco, numero FROM tbcliente";

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
                        Clientes cliente = new Clientes
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Email = reader["email"].ToString(),
                            Telefone = reader["telefone"].ToString(),
                            Status = reader["status"].ToString(),
                            Sexo = reader["sexo"].ToString(),
                            Documento = reader["documento"].ToString(),
                            Datanasc = reader["datanasc"].ToString(),
                            Uf = reader["uf"].ToString(),
                            Cidade = reader["cidade"].ToString(),
                            Bairro = reader["bairro"].ToString(),
                            Endereco = reader["endereco"].ToString(),
                            Numero = Convert.ToInt32(reader["numero"])
                        };

                        clientes.Add(cliente);
                    }
                } // O reader será fechado automaticamente aqui
            } // A conexão será fechada automaticamente aqui, ao sair do bloco 'using'
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar usuários: " + ex.Message);
        }

        return clientes;
    }

    public void PreencherDataGridView(DataGridView grid)
    {
        var clientes = ObterCliente();

        // Converte a lista para um DataTable (opcional, mas recomendado para grids)
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Nome", typeof(string));
        table.Columns.Add("Email", typeof(string));
        table.Columns.Add("Telefone", typeof(string));
        table.Columns.Add("Status", typeof(string));


        foreach (var cliente in clientes)
        {
            table.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.Telefone, cliente.Status);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //grid.Columns["Senha"].Visible = false; // Oculta a senha, se necessário
    }

    public List<Clientes> FiltrarClientes(string termo, string status)
    {
        List<Clientes> clientes = new List<Clientes>();

        try
        {
            // Define a consulta SQL
            string query = "SELECT id, nome, email, telefone, status, sexo, documento, datanasc, uf, cidade, bairro, endereco, numero " +
                           "FROM tbcliente " +
                           "WHERE (nome LIKE @Termo OR email LIKE @Termo OR documento LIKE @Termo)";

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
                    Clientes cliente = new Clientes
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = reader["nome"].ToString(),
                        Email = reader["email"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        Status = reader["status"].ToString(),
                        Sexo = reader["sexo"].ToString(),
                        Documento = reader["documento"].ToString(),
                        Datanasc = reader["datanasc"].ToString(),
                        Uf = reader["uf"].ToString(),
                        Cidade = reader["cidade"].ToString(),
                        Bairro = reader["bairro"].ToString(),
                        Endereco = reader["endereco"].ToString(),
                        Numero = Convert.ToInt32(reader["numero"])
                    };

                    clientes.Add(cliente);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao filtrar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return clientes;
    }

    public void AtualizarDataGridView(DataGridView grid, List<Clientes> clientes)
    {
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Nome", typeof(string));
        table.Columns.Add("Email", typeof(string));
        table.Columns.Add("Telefone", typeof(string));
        table.Columns.Add("Status", typeof(string));

        foreach (var cliente in clientes)
        {
            table.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.Telefone, cliente.Status);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //grid.Columns["Senha"].Visible = false; // Oculta a senha, se necessário
    }

    public bool ExcluirCliente(Clientes cliente)
    {
        if (cliente == null || cliente.Id <= 0)
            throw new ArgumentException("Cliente inválido para exclusão.");

        try
        {
            // Usando o bloco using para garantir que a conexão será fechada automaticamente
            using (var conexao = new Conexao())
            {
                string query = "DELETE FROM tbcliente WHERE id = @Id";
                var command = conexao.CriarComando(query);
                command.Parameters.AddWithValue("@Id", cliente.Id);

                conexao.Conectar(); // Certifica-se de que a conexão está aberta
                int linhasAfetadas = command.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
        }
        catch (Exception ex)
        {
            // Lidar com o erro (log ou mensagem ao usuário)
            MessageBox.Show($"Erro ao excluir Cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public Clientes ObterClientePorId(int id)
    {
        Clientes cliente = null;

        try
        {
            string query = "SELECT id, nome, email, telefone, status, sexo, documento, datanasc, uf, cidade, bairro, endereco, numero FROM tbcliente WHERE id = @id";

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
                            cliente = new Clientes
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Email = reader["email"].ToString(),
                                Telefone = reader["telefone"].ToString(),
                                Status = reader["status"].ToString(),
                                Sexo = reader["sexo"].ToString(),
                                Documento = reader["documento"].ToString(),
                                Datanasc = reader["datanasc"].ToString(),
                                Uf = reader["uf"].ToString(),
                                Cidade = reader["cidade"].ToString(),
                                Bairro = reader["bairro"].ToString(),
                                Endereco = reader["endereco"].ToString(),
                                Numero = Convert.ToInt32(reader["numero"])
                            };
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao obter dados do usuário: {ex.Message}");
        }

        return cliente;
    }

    public void AtualizarCliente(Clientes cliente)
    {
        try
        {
            // Atualiza o banco de dados
            using (var conexao = new Conexao())
            {
                string query = "UPDATE tbcliente SET nome = @nome, email = @email, telefone = @telefone, status = @status, sexo = @sexo, documento = @documento, datanasc = @datanasc, uf = @uf, cidade = @cidade, bairro = @bairro, endereco = @endereco, numero = @numero WHERE id = @id";

                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@status", cliente.Status);
                    comando.Parameters.AddWithValue("@sexo", cliente.Sexo);
                    comando.Parameters.AddWithValue("@documento", cliente.Documento);
                    comando.Parameters.AddWithValue("@datanasc", cliente.Datanasc);
                    comando.Parameters.AddWithValue("@uf", cliente.Uf);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@id", cliente.Id);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cliente atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar o cliente: {ex.Message}");
        }
    }

    public bool InserirCliente(Clientes cliente)
    {
        bool sucesso = false;

        try
        {
            // Insere os dados no banco de dados
            using (var conexao = new Conexao())
            {
                string query = @"
                INSERT INTO tbcliente (id, nome, email, telefone, status, sexo, documento, datanasc, uf, cidade, bairro, endereco, numero)
                VALUES (@guid, @id, @nome, @email, @telefone, @status, @sexo, @documento, @datanasc, @uf, @cidade, @bairro, @endereco, @numero)";

                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@guid", Guid.NewGuid().ToString());
                    comando.Parameters.AddWithValue("@id", Globais.gerarNovoID("tbcliente"));
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@status", cliente.Status);
                    comando.Parameters.AddWithValue("@sexo", cliente.Sexo);
                    comando.Parameters.AddWithValue("@documento", cliente.Documento);
                    comando.Parameters.AddWithValue("@datanasc", cliente.Datanasc);
                    comando.Parameters.AddWithValue("@uf", cliente.Uf);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@id", cliente.Id);

                    comando.ExecuteNonQuery();
                    sucesso = true;
                }
            }

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}");
        }

        return sucesso;
    }

}
