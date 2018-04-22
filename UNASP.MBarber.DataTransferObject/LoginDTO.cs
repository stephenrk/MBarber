using System;

namespace UNASP.MBarber.DataTransferObject
{
    public class LoginDTO
    {
        public Guid Id { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }

        public DateTime DataInclusao { get; set; }

        public ClienteDTO Clientes { get; set; }
    }
}
