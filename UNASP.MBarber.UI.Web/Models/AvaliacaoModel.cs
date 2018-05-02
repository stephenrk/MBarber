using System;

namespace UNASP.MBarber.UI.Web.Models
{
    public class AvaliacaoModel
    {
        public AvaliacaoModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nota { get; set; }
        public string Descricao { get; set; }
    
        public ServicoModel Servico { get; set; }
    }
}
