using System.Collections.Generic;
using UNASP.MBarber.DAO;
using UNASP.Projeto.DTO;

namespace UNASP.MBarber.Repository
{
    public class ClienteRepository
    {
        private MbarberEntities _conexao = new MbarberEntities();

        public void Cadastrar(ClienteDTO novoCliente)
        {
            var clienteTabela = new Cliente
            {
                Nome = novoCliente.Nome,
                Sobrenome = novoCliente.Sobrenome,
                Cpf = novoCliente.Cpf,
                Telefone = novoCliente.Telefone,
                Endereco = novoCliente.Endereco,
                Servicos = novoCliente.Servicos
            };
        }

        public void Delete(string ID)
        {
            target.Delete(ID);
        }

        public Cliente GetById(string ID)
        {
            return target.GetById(ID);
        }
        public List<Cliente> GetAllClientes(Cliente Cliente)
        {
            return target.GetAllClientes(Cliente);
        }
    }
}
