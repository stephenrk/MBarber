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
    
    public partial class Avaliacao
    {
        public int Id { get; set; }
        public string Nota { get; set; }
        public string Descricao { get; set; }
        public int AgendamentoId { get; set; }
    
        public virtual Agendamento Agendamento { get; set; }
    }
}
