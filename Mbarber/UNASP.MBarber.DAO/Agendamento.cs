//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNASP.MBarber.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agendamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agendamento()
        {
            this.Avaliacoes = new HashSet<Avaliacao>();
        }
    
        public int Id { get; set; }
        public System.DateTime DataHora { get; set; }
        public int EmpresaId { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}
