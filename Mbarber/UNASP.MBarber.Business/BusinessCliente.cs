using UNASP.Projeto.DAO;
using UNASP.Projeto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UNASP.Projeto.Business
{
    public class BusinessCliente 
    {
        private DataCliente target = new DataCliente();
        

        public Cliente Save(Cliente Cliente)
        {
            if (string.IsNullOrWhiteSpace(Cliente.CliNome))
                throw new Exception("Sobre Nome Invalido");
            if (string.IsNullOrWhiteSpace(Cliente.CliSobreNome))
                throw new Exception("Nome Invalido");
            return target.Save(Cliente);
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
