using System;
using System.Linq;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.Repository.ConnectionContext.Context;

namespace UNASP.MBarber.Repository
{
    public class ImagemRepository
    {
        public Imagem BuscarPorId(Guid id)
        {
            using (MBarberContext _context = new MBarberContext())
            {
                return _context.Imagem.Where(l => l.Id == id).FirstOrDefault();
            }
        }
    }
}
