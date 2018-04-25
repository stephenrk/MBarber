using System;

namespace UNASP.MBarber.UI.Web.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        //public List<Agendamento> Agendamentos { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public LoginViewModel Login { get; set; }
    }
}