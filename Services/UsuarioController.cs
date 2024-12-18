using Biblion.DAL;
using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data; // Para DataTable
using System.Windows.Forms; // Para o DataGridView

public class UsuarioController
{
    private Conexao conexao;

    public UsuarioController()
    {
        conexao = new Conexao(); // Supondo que você já tenha a classe Conexao implementada
    }

    public List<Usuarios> ObterUsuarios()
    {
        List<Usuarios> usuarios = new List<Usuarios>();

        try
        {
            string query = "SELECT id, nome, login, senha, status, acesso, img FROM tbusuarios";

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
                        Usuarios usuario = new Usuarios
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Login = reader["login"].ToString(),
                            Senha = reader["senha"].ToString(),
                            Status = reader["status"].ToString(),
                            Acesso = Convert.ToInt32(reader["acesso"]),
                            Img = reader["img"].ToString()
                        };

                        usuarios.Add(usuario);
                    }
                } // O reader será fechado automaticamente aqui
            } // A conexão será fechada automaticamente aqui, ao sair do bloco 'using'
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao buscar usuários: " + ex.Message);
        }

        return usuarios;
    }


    public void PreencherDataGridView(DataGridView grid)
    {
        var usuarios = ObterUsuarios();

        // Converte a lista para um DataTable (opcional, mas recomendado para grids)
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Nome", typeof(string));
        table.Columns.Add("Login", typeof(string));
        table.Columns.Add("Senha", typeof(string));
        table.Columns.Add("Status", typeof(string));
        table.Columns.Add("Acesso", typeof(int));
        table.Columns.Add("Img", typeof(string));

        foreach (var usuario in usuarios)
        {
            table.Rows.Add(usuario.Id, usuario.Nome, usuario.Login, usuario.Senha, usuario.Status, usuario.Acesso, usuario.Img);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.Columns["Senha"].Visible = false; // Oculta a senha, se necessário
    }

    public List<Usuarios> FiltrarUsuarios(string termo, string status)
    {
        List<Usuarios> usuarios = new List<Usuarios>();

        try
        {
            // Define a consulta SQL
            string query = "SELECT id, nome, login, senha, status, acesso, img " +
                           "FROM tbusuarios " +
                           "WHERE (nome LIKE @Termo OR login LIKE @Termo)";

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
                    Usuarios usuario = new Usuarios
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nome = reader["Nome"].ToString(),
                        Login = reader["Login"].ToString(),
                        Senha = reader["Senha"].ToString(),
                        Status = reader["Status"].ToString(),
                        Acesso = Convert.ToInt32(reader["Acesso"]),
                        Img = reader["Img"].ToString()
                    };

                    usuarios.Add(usuario);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao filtrar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return usuarios;
    }

    public void AtualizarDataGridView(DataGridView grid, List<Usuarios> usuarios)
    {
        DataTable table = new DataTable();
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Nome", typeof(string));
        table.Columns.Add("Login", typeof(string));
        table.Columns.Add("Senha", typeof(string));
        table.Columns.Add("Status", typeof(string));
        table.Columns.Add("Acesso", typeof(int));
        table.Columns.Add("Img", typeof(string));

        foreach (var usuario in usuarios)
        {
            table.Rows.Add(usuario.Id, usuario.Nome, usuario.Login, usuario.Senha, usuario.Status, usuario.Acesso, usuario.Img);
        }

        grid.DataSource = table;

        // Ajusta o layout das colunas (opcional)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.Columns["Senha"].Visible = false; // Oculta a senha, se necessário
    }

    public bool ExcluirUsuario(Usuarios usuario)
    {
        if (usuario == null || usuario.Id <= 0)
            throw new ArgumentException("Usuário inválido para exclusão.");

        try
        {
            // Usando o bloco using para garantir que a conexão será fechada automaticamente
            using (var conexao = new Conexao())
            {
                string query = "DELETE FROM tbusuarios WHERE id = @Id";
                var command = conexao.CriarComando(query);
                command.Parameters.AddWithValue("@Id", usuario.Id);

                conexao.Conectar(); // Certifica-se de que a conexão está aberta
                int linhasAfetadas = command.ExecuteNonQuery();

                return linhasAfetadas > 0;
            }
        }
        catch (Exception ex)
        {
            // Lidar com o erro (log ou mensagem ao usuário)
            MessageBox.Show($"Erro ao excluir usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

}