using System;

namespace UNASP.MBarber.UI.Web.Models
{
    public class ServicoModel
    {
        public ServicoModel()
        {
            this.Id = Guid.NewGuid();
        }
    
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
    
        public AgendamentoModel Agendamento { get; set; }
        public AvaliacaoModel Avaliacao { get; set; }
        public EmpresaModel Empresa { get; set; }
    }
}
