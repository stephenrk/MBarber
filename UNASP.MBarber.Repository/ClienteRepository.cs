using System;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.Repository.ConnectionContext.Context;

namespace UNASP.MBarber.Repository
{
    public class ClienteRepository
    {
        public void Inserir(Cliente cliente)
        {
            cliente.Login.Tipo = "C";
            cliente.Login.DataInclusao = DateTime.Now;

            using (MBarberContext _context = new MBarberContext())
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
        }
    }
}
