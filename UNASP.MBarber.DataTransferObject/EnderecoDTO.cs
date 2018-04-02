using System.Collections.Generic;

namespace UNASP.MBarber.DataTransferObject
{
    public class EnderecoDTO
    {
        public EnderecoDTO()
        {
            this.Clientes = new HashSet<ClienteDTO>();
            this.Empresas = new HashSet<EmpresaDTO>();
        }

        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public ICollection<ClienteDTO> Clientes { get; set; }
        public ICollection<EmpresaDTO> Empresas { get; set; }
    }
}