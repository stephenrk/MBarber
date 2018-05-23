using System;

namespace UNASP.MBarber.Repository.ConnectionContext
{
    public partial class Imagem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public byte[] Picture { get; set; }
        public string ContentType { get; set; }
    }
}
