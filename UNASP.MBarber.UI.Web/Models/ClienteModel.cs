using System;
using System.Collections.Generic;

namespace UNASP.MBarber.UI.Web.Models
{

    public class ClienteModel
    {
        public ClienteModel()
        {
            this.Agendamentos = new List<AgendamentoModel>();
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        public IList<AgendamentoModel> Agendamentos { get; set; }
        public EnderecoModel Endereco { get; set; }
        public LoginModel Logins { get; set; }
    }
}
