//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNASP.MBarber.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public System.Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public System.DateTime DataInclusao { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
