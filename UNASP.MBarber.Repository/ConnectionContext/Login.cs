namespace UNASP.MBarber.Repository.ConnectionContext
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Login
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Senha { get; set; }

        public DateTime DataInclusao { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }
    }
}
