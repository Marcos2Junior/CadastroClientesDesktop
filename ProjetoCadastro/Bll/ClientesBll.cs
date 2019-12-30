using System;
using System.Data;
using ProjetoCadastro.Model;
using ProjetoCadastro.DAO;

namespace ProjetoCadastro.Bll
{
    class ClientesBll
    {
        AdicionarCliente Cliente = new AdicionarCliente();

        public void Salvar(ClasseDados cliente)
        {
            try
            {
                Cliente.Salvar(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Cliente.Listar();

                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        
        public void Editar(ClasseDados classeDados)
        {
            try
            {
                Cliente.Editar(classeDados);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(ClasseDados cliente)
        {
            try
            {
                Cliente.Excluir(cliente);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
