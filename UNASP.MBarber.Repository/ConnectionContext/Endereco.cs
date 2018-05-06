namespace UNASP.MBarber.Repository.ConnectionContext
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Enderecos")]
    public partial class Endereco
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Cep { get; set; }

        [Required]
        [StringLength(150)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(20)]
        public string Numero { get; set; }

        [StringLength(150)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
    }
}
