using System;
using System.Collections.Generic;

namespace UNASP.MBarber.DataTransferObject
{
    public class AgendamentoDTO
    {
        public AgendamentoDTO()
        {
            this.Avaliacoes = new HashSet<AvaliacaoDTO>();
        }

        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int EmpresaId { get; set; }
        public int ClienteId { get; set; }

        public ClienteDTO Cliente { get; set; }
        public EmpresaDTO Empresa { get; set; }
        public ICollection<AvaliacaoDTO> Avaliacoes { get; set; }
    }
}
