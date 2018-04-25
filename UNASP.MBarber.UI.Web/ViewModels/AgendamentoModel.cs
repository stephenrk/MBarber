using System;
using System.Collections.Generic;

namespace UNASP.MBarber.UI.Web.ViewModels
{
    public class AgendamentoModel
    {
        public AgendamentoModel()
        {
            this.Servicos = new List<ServicoModel>();
        }
    
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public ClienteModel Cliente { get; set; }
        public IList<ServicoModel> Servicos { get; set; }
    }
}
