using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UNASP.Projeto.DTO
{
    public class Agendamento
    {
        [Key]
        public int AgendId { get; set; }
        public string DataHora { get; set; }
        public string Status { get; set; }
        public int EmpCNPJ { get; set; }
        public int CLiCPF { get; set; }
    }
}