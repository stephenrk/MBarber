using System;
using System.Collections.Generic;

namespace UNASP.MBarber.UI.Web.ViewModels
{
    public class EmpresaModel
    {
        public EmpresaModel()
        {
            this.Servicos = new List<ServicoModel>();
            this.Id = Guid.NewGuid();
        }
    
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string NomeReduzido { get; set; }
    
        public EnderecoModel Endereco { get; set; }
        public IList<ServicoModel> Servicos { get; set; }
    }
}
