using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UNASP.Projeto.DTO
{
    public class Servico
    {
        [Key]
        public int ServID { get; set; }
        public string CliNome { get; set; }
        public double Valor { get; set; }
        public int EmpCNPJ { get; set; }
    }
}