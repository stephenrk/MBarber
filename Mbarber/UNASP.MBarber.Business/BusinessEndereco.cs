using UNASP.Projeto.DAO;
using UNASP.Projeto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UNASP.Projeto.Business
{
    public class BusinessEndereco
    {
        private DataEndereco target = new DataEndereco();


        public Endereco Save(Endereco Endereco)
        {
            /*
            if (string.IsNullOrWhiteSpace(Endereco.CliNome))
                throw new Exception("Sobre Nome Invalido");
            if (string.IsNullOrWhiteSpace(Endereco.CliSobreNome))
                throw new Exception("Nome Invalido");
                */
            return target.Save(Endereco);
        }

        public void Delete(int ID)
        {
            target.Delete(ID);
        }

        public Endereco GetById(int ID)
        {
            return target.GetById(ID);
        }
        
    }
}
