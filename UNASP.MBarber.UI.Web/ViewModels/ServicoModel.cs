using System;
using System.Collections.Generic;

namespace UNASP.MBarber.UI.Web.ViewModels
{
    public class ServicoModel
    {
        public ServicoModel()
        {
            this.Avaliacoes = new List<AvaliacaoModel>();
            this.Id = Guid.NewGuid();
        }
    
        public Guid Id { get; set; }
        public int AgendamentoId { get; set; }
        public Guid EmpresaId { get; set; }
        public decimal Valor { get; set; }
    
        public AgendamentoModel Agendamento { get; set; }
        public IList<AvaliacaoModel> Avaliacoes { get; set; }
        public EmpresaModel Empresa { get; set; }
    }
}
