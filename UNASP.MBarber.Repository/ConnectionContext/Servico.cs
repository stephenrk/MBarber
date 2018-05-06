namespace UNASP.MBarber.Repository.ConnectionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Servicos")]
    public partial class Servico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servico()
        {
            Avaliacoes = new HashSet<Avaliacao>();
        }

        public Guid Id { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Valor { get; set; }

        public virtual Agendamento Agendamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
