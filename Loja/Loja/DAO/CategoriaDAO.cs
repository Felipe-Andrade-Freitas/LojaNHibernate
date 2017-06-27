using Loja.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    public class CategoriaDAO
    {
        private ISession session;

        public CategoriaDAO(ISession session)
        {
            this.session = session;
        }

        public void SalvaCategoria(Categoria categoria )
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(categoria);
            transacao.Commit();
        }

        public Categoria BuscaPorId(int id)
        {
            return session.Get<Categoria>(id);
        }
    }
}
