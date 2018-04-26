using System;

namespace UNASP.MBarber.UI.Web.ViewModels
{

    public class ClienteModel
    {
        public ClienteModel()
        {
            this.Id = Guid.NewGuid();
        }
    
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
    
        public EnderecoModel Endereco { get; set; }
    }
}
