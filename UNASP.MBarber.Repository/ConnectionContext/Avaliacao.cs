namespace UNASP.MBarber.Repository.ConnectionContext
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Avaliacao
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Nota { get; set; }

        public string Descricao { get; set; }

        public Guid ServicoId { get; set; }

        public virtual Servico Servico { get; set; }
    }
}
