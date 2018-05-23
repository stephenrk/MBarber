using System;
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

        public void Inserir(Empresa empresa)
        {
            empresa.DataInclusao = DateTime.Now;

            using (MBarberContext _context = new MBarberContext())
            {
                _context.Empresas.Add(empresa);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Empresa> ListarBarbearias()
        {
            return _context.Empresas;
        }
    }
}
