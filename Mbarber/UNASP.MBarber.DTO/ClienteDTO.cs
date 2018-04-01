using System;
using System.Collections.Generic;

namespace UNASP.Projeto.DTO
{
    public class ClienteDTO
    {
        public ClienteDTO()
        {
            this.Agendamentos = new List<Agendamento>();
            this.Servicos = new List<Servico>();
        }

        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }
        public Guid UserId { get; set; }

        public ICollection<Agendamento> Agendamentos { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Servico> Servicos { get; set; }
    }
}