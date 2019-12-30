using System;
using MySql.Data.MySqlClient;
using ProjetoCadastro.Model;
using System.Data;

namespace ProjetoCadastro.DAO
{
    class AdicionarCliente : ClasseConnection
    {
        MySqlCommand comando = null;

        //MÉTODO PARA SALVAR OS DADOS NO BANCO
        public void Salvar(ClasseDados classeDados)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO clientes (cpf,nome,nascimento,cep,endereco,numero,cidade,bairro,estado,telefone,email) VALUES (@cpf, @nome, @nascimento, @cep, @endereco, @numero, @cidade, @bairro, @estado, @telefone, @email)", conexao);
                comando.Parameters.AddWithValue("@cpf", classeDados.Cpf);
                comando.Parameters.AddWithValue("@nome", classeDados.Nome);
                comando.Parameters.AddWithValue("@nascimento", classeDados.Nascimento);
                comando.Parameters.AddWithValue("@cep", classeDados.Cep);
                comando.Parameters.AddWithValue("@endereco", classeDados.Endereco);
                comando.Parameters.AddWithValue("@numero", classeDados.Numero);
                comando.Parameters.AddWithValue("@cidade", classeDados.Cidade);
                comando.Parameters.AddWithValue("@bairro", classeDados.Bairro);
                comando.Parameters.AddWithValue("@estado", classeDados.Estado);
                comando.Parameters.AddWithValue("@telefone", classeDados.Telefone);
                comando.Parameters.AddWithValue("@email", classeDados.Email);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //MÉTODO PARA LISTAR OS DADOS NO DATAGRIDVIEW
        public DataTable Listar()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM clientes ORDER BY nome", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }


        // MÉTODO PARA EDITAR OS DADOS 
        public void Editar(ClasseDados classeDados)
        {
            try
            {

                AbrirConexao();

                comando = new MySqlCommand("UPDATE clientes SET cpf = @cpf,nome = @nome, nascimento = @nascimento,cep = @cep, endereco = @endereco, numero = @numero, cidade = @cidade, bairro = @bairro, estado = @estado, telefone = @telefone, email = @email WHERE idclientes = @id", conexao);
                comando.Parameters.AddWithValue("@id", classeDados.Id);

                
                comando.Parameters.AddWithValue("@cpf", classeDados.Cpf);
                comando.Parameters.AddWithValue("@nome", classeDados.Nome);
                comando.Parameters.AddWithValue("@nascimento", classeDados.Nascimento);
                comando.Parameters.AddWithValue("@cep", classeDados.Cep);
                comando.Parameters.AddWithValue("@endereco", classeDados.Endereco);
                comando.Parameters.AddWithValue("@numero", classeDados.Numero);
                comando.Parameters.AddWithValue("@cidade", classeDados.Cidade);
                comando.Parameters.AddWithValue("@bairro", classeDados.Bairro);
                comando.Parameters.AddWithValue("@estado", classeDados.Estado);
                comando.Parameters.AddWithValue("@telefone", classeDados.Telefone);
                comando.Parameters.AddWithValue("@email", classeDados.Email);

                comando.ExecuteNonQuery();

            }
            catch(Exception erro)
            {
                throw erro;

            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir (ClasseDados cliente)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM clientes WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("id", cliente.Id);

                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
