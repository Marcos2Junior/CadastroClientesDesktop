using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoCadastro.DAO
{
    class ClasseConnection
    {
        string conectaBanco = "SERVER=localhost; database=cadastro; user id=root;";
        protected MySqlConnection conexao = null;


        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                conexao.Open();


            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}

