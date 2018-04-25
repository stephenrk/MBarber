using System.Collections.Generic;

namespace UNASP.MBarber.UI.Web.ViewModels
{
    public class EnderecoModel
    {
        public EnderecoModel()
        {
            this.Clientes = new List<ClienteModel>();
            this.Empresas = new List<EmpresaModel>();
        }
    
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    
        public IList<ClienteModel> Clientes { get; set; }
        public IList<EmpresaModel> Empresas { get; set; }
    }
}
