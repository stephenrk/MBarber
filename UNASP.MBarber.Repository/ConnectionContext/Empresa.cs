namespace UNASP.MBarber.Repository.ConnectionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            Servicos = new HashSet<Servico>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Cnpj { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeReduzido { get; set; }

        public virtual Endereco Endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servico> Servicos { get; set; }
    }
}
