using System;

namespace UNASP.MBarber.UI.Web.Models
{
    public class LoginModel
    {
        public LoginModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Tipo { get; set; }
    }
}
