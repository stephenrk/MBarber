using System;

namespace UNASP.MBarber.UI.Web.Models
{
    public class ImagemModel
    {
        public ImagemModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public byte[] Picture { get; set; }
        public string ContentType { get; set; }
    }
}