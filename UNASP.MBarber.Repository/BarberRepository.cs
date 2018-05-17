using System.Collections.Generic;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.Repository.ConnectionContext.Context;

namespace UNASP.MBarber.Repository
{
    public class BarberRepository
    {
        private readonly MBarberContext _context = new MBarberContext();

        public IEnumerable<TipoServico> ListarTiposServicos()
        {
            return _context.TipoServico;
        }
    }
}
