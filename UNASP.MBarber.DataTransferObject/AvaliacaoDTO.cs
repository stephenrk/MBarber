using System;

namespace UNASP.MBarber.DataTransferObject
{
    public class AvaliacaoDTO
    {
        public Guid Id { get; set; }
        public string Nota { get; set; }
        public string Descricao { get; set; }
        public int AgendamentoId { get; set; }

        public AgendamentoDTO Agendamento { get; set; }
    }
}