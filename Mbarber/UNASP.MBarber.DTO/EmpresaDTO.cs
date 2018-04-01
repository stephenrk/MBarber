using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UNASP.Projeto.DTO
{
    public class Empresa
    {
        [Key]
        public int EmpCNPJ { get; set; }
        public string EmpNome { get; set; }
        public string EmpNomeRedu { get; set; }
        public int EndId { get; set; }
    }
}