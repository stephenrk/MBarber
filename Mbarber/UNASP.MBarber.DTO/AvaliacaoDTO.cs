using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UNASP.Projeto.DTO
{
    public class Avaliacao
    {
        [Key]
        public int AvaliacaoId { get; set; }
        public string Nota { get; set; }
        public string Descricao { get; set; }
        public int AgendId { get; set; }
    }
}