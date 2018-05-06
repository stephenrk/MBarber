using Dapper;
using System;
using System.Linq;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.Repository.ConnectionContext.Context;

namespace UNASP.MBarber.Repository
{
    public class LoginRepository
    {
        public Login BuscarPorEmail(string email)
        {
            using (MBarberContext _context = new MBarberContext())
            {
                var sql = "SELECT * FROM LOGINS WHERE EMAIL = @email ";

                var e = _context.Database.Connection.Query(sql,
                    param: new
                    {
                        email = email
                    });

                return e.FirstOrDefault();
            }
        }

        public Login AutenticarAcesso(string email, string senha)
        {
            using (MBarberContext _context = new MBarberContext())
            {
                return _context.Logins.Where(l => l.Email == email && l.Senha == senha).FirstOrDefault(); ;
            }
        }

        public object ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
