using System;

namespace UNASP.MBarber.DataTransferObject
{
    public class ServicoDTO
    {
        public Guid Id { get; set; }
        public int ClienteId { get; set; }
        public int EmpresaId { get; set; }
        public decimal Valor { get; set; }

        public ClienteDTO Cliente { get; set; }
        public EmpresaDTO Empresa { get; set; }
    }
}