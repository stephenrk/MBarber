using System;
using System.Collections.Generic;

namespace UNASP.MBarber.DataTransferObject
{
    public class LoginDTO
    {
        public LoginDTO()
        {
            this.Clientes = new List<ClienteDTO>();
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataInclusao { get; set; }

        public virtual List<ClienteDTO> Clientes { get; set; }
    }
}
