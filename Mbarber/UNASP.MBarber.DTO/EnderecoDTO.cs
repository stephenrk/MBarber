using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UNASP.Projeto.DTO
{
    public class Endereco
    {
        [Key]
        public int EndId { get; set; }
        public int EndCEP { get; set; }
        public string EndLogradouro { get; set; }
        public string EndNumero { get; set; }
        public string EndComplemento { get; set; }
        public string EndBairro { get; set; }
        public string EndCidade { get; set; }
        public string EndEstado { get; set; }
        public string EndRua{ get; set; }

        public virtual ICollection<ClienteDTO> Clientes { get; set; }
    }
}