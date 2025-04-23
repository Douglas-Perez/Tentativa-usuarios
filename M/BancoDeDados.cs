using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.M
{
    class BancoDeDados
    {
        private string _connectionDB = "Server=localhost;Database=usermanagement;Uid=root;Pwd=;";
        public DataTable ExecutarConsultas(string sql)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(_connectionDB))
                {
                    conexao.Open();

                    using (MySqlCommand comandoDB = new MySqlCommand(sql, conexao))
                    {
                        MySqlDataAdapter transportarDadosDB = new MySqlDataAdapter(comandoDB);
                        transportarDadosDB.Fill(tabela);
                    }
                    conexao.Close();
                }

            }
            catch (Exception ex)
            {
                //Throw new Exception serve para lançar uma exeção para caso o ocorra erro de conexão com o banco
                throw new Exception("Erro ao acessar o banco: " + ex.Message);
            }

            return tabela;
        }
        public bool UpdateUsuarioPorId(int id, string name, string email)
        {
            string sql = "UPDATE users SET name = @name, email = @email WHERE id = @id;";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(_connectionDB))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@name", name);
                        comando.Parameters.AddWithValue("@email", email);

                        return true ? comando.ExecuteNonQuery() > 0 : false;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return false;
            }
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            string sql = "SELECT id, name, email FROM users WHERE id = @id LIMIT 1;";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(_connectionDB))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Usuario
                                {
                                    Id = reader.GetInt32("id"),
                                    Name = reader.GetString("name"),
                                    Email = reader.GetString("email"),
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar usuário: {ex.Message}");
            }

            return null; // Retorna null se não encontrar
        }

        public int InserirUsuario(string name, string email)
        {
            string sql = "INSERT INTO users (name, email) VALUES (@name, @email)";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(_connectionDB))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@name", name);
                        comando.Parameters.AddWithValue("@email", email);

                        return comando.ExecuteNonQuery();
                    }
                }
            } catch (Exception)
            {   
                return 0;
            }
        }
        public bool DeletarUsuario(int id)
        {
            string sql = "DELETE FROM users WHERE id = @id";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(_connectionDB))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        return true ? comando.ExecuteNonQuery() > 0 : false;
                    }
                }
            } catch(Exception er)
            {
                MessageBox.Show(er.Message);
                return false;
            }
        }
        public bool AcharUsuario(int id)
        {
            string sql = "SELECT count(*) FROM users WHERE id = @id;";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(_connectionDB))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        return Convert.ToInt32(comando.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return false;
            }
        }
    }
}