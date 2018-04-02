using System;
using System.Collections.Generic;

namespace UNASP.MBarber.DataTransferObject
{
    public class ClienteDTO
    {
        public ClienteDTO()
        {
            this.Agendamentos = new HashSet<AgendamentoDTO>();
            this.Servicos = new HashSet<ServicoDTO>();
        }

        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }
        public Guid LoginId { get; set; }

        public ICollection<AgendamentoDTO> Agendamentos { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public LoginDTO Login { get; set; }
        public ICollection<ServicoDTO> Servicos { get; set; }
    }
}
