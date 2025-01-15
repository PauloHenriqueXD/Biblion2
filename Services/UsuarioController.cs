using Biblion.DAL;
using Biblion.Entities;
using System;
using System.Collections.Generic;
using System.Data; // Para DataTable
using System.IO;
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

    public Usuarios ObterUsuarioPorId(int id)
    {
        Usuarios usuario = null;

        try
        {
            string query = "SELECT id, nome, login, senha, status, acesso, img FROM tbusuarios WHERE id = @id";

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
                            usuario = new Usuarios
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Login = reader["login"].ToString(),
                                Senha = reader["senha"].ToString(),
                                Status = reader["status"].ToString(),
                                Acesso = Convert.ToInt32(reader["acesso"]),
                                Img = reader["img"].ToString()
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

        return usuario;
    }

    public void AtualizarUsuario(Usuarios usuario, string caminhoImagemSelecionada)
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
                string queryBusca = "SELECT img FROM tbusuarios WHERE id = @id";
                using (var comandoBusca = conexao.CriarComando(queryBusca))
                {
                    comandoBusca.Parameters.AddWithValue("@id", usuario.Id);
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
                usuario.Img = novoCaminhoImagem; // Salva o caminho completo
            }

            // Atualiza o banco de dados
            using (var conexao = new Conexao())
            {
                string query = "UPDATE tbusuarios SET nome = @nome, login = @login, senha = @senha, status = @status, acesso = @acesso, img = @img WHERE id = @id";
                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@login", usuario.Login);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@status", usuario.Status);
                    comando.Parameters.AddWithValue("@acesso", usuario.Acesso);
                    comando.Parameters.AddWithValue("@img", usuario.Img); // Salva o caminho completo no banco
                    comando.Parameters.AddWithValue("@id", usuario.Id);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuário atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar o usuário: {ex.Message}");
        }
    }

    public bool InserirUsuario(Usuarios usuario)
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
            if (!string.IsNullOrEmpty(usuario.Img))
            {
                string nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(usuario.Img);
                string caminhoCompletoImagem = Path.Combine(pastaImg, nomeArquivo);

                File.Copy(usuario.Img, caminhoCompletoImagem, true);

                // Atualiza o caminho no objeto usuário
                usuario.Img = caminhoCompletoImagem;
            }

            // Insere os dados no banco de dados
            using (var conexao = new Conexao())
            {
                string query = @"
                INSERT INTO tbusuarios (guid, id, nome, login, senha, status, acesso, img)
                VALUES (@guid, @id, @nome, @login, @senha, @status, @acesso, @img)";

                using (var comando = conexao.CriarComando(query))
                {
                    comando.Parameters.AddWithValue("@guid", Guid.NewGuid());
                    comando.Parameters.AddWithValue("@id", Globais.gerarNovoID("tbusuarios"));
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@login", usuario.Login);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@status", usuario.Status);
                    comando.Parameters.AddWithValue("@acesso", usuario.Acesso);
                    comando.Parameters.AddWithValue("@img", usuario.Img);

                    comando.ExecuteNonQuery();
                    sucesso = true;
                }
            }

            MessageBox.Show("Usuário cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
        }

        return sucesso;
    }


}