namespace UNASP.MBarber.Repository.ConnectionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Agendamentos")]
    public partial class Agendamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agendamento()
        {
            Servicos = new HashSet<Servico>();
        }

        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servico> Servicos { get; set; }
    }
}
