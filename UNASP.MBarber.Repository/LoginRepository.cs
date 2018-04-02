using System;
using System.Linq;
using UNASP.MBarber.DataAccess;

namespace UNASP.MBarber.Repository
{
    public class LoginRepository
    {
        private MbarberEntities _conexao = new MbarberEntities();

        public Login BuscarPorEmail(string email)
        {
            return _conexao.Logins.Find(email);
        }

        public Login AutenticarAcesso(string email, string senha)
        {
            return _conexao.Logins.Where(l => l.Email == email && l.Senha == senha).FirstOrDefault();
        }

        public void Inserir(Login loginDomain)
        {
            throw new NotImplementedException();
        }

        public object ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
