using System.ComponentModel.DataAnnotations.Schema;

namespace UNASP.MBarber.Repository.ConnectionContext
{
    [Table("TipoServico")]
    public partial class TipoServico
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}
