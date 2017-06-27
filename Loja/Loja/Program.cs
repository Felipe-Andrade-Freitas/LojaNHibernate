using Loja.DAO;
using Loja.INFRA;
using Loja.Model;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GeraSchema();



            //ISession session = NHibernateHelper.AbreSession();

            //UsuarioDAO usuarioDAO = new UsuarioDAO(session);
            //Usuario novoUsuario = new Usuario();

            //novoUsuario.Nome = "João";
            //usuarioDAO.Adiciona(novoUsuario);
            //session.Close();

            Console.WriteLine("==============================================================");



            Categoria umaCategoria = new Categoria();
            umaCategoria.Nome = "Vestuario".ToUpper();

            Produto produto = new Produto();
            produto.Nome = "calça".ToUpper();
            produto.Preco = 10;
            //produto.Categoria = umaCategoria;
            produto.Categoria = umaCategoria;

            ISession session = NHibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();

            session.Save(umaCategoria);
            session.Save(produto);

            transacao.Commit();
            session.Close();

            Console.Read();
        }
    }
}
