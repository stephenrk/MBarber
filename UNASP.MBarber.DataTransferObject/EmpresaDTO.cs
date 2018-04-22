using System;
using System.Collections.Generic;

namespace UNASP.MBarber.DataTransferObject
{
    public class EmpresaDTO
    {
        public EmpresaDTO()
        {
            this.Agendamentos = new HashSet<AgendamentoDTO>();
            this.Servicos = new HashSet<ServicoDTO>();
        }

        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string NomeReduzido { get; set; }
        public int EnderecoId { get; set; }

        public ICollection<AgendamentoDTO> Agendamentos { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public ICollection<ServicoDTO> Servicos { get; set; }
    }
}