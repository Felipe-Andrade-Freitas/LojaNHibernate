using Loja.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    public class ProdutoDAO
    {
        private ISession session;

        public ProdutoDAO(ISession session)
        {
            this.session = session;
        }

        public void SalvaProduto(Produto produto)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(produto);
            transacao.Commit();
        }

        public Produto BuscaPorId(int id)
        {
            return session.Get<Produto>(id);
        }
    }
}
