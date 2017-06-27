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
            //NHibernateHelper.GeraSchema();

            //ISession session = NHibernateHelper.AbreSession();

            //UsuarioDAO usuarioDAO = new UsuarioDAO(session);
            //Usuario novoUsuario = new Usuario();

            //novoUsuario.Nome = "João";
            //usuarioDAO.Adiciona(novoUsuario);
            //session.Close();

            Console.WriteLine("==============================================================");

            //ISession session = NHibernateHelper.AbreSession();

            //CategoriaDAO categoriaDao = new CategoriaDAO(session);
            //Categoria umaCategoria = new Categoria();
            //ProdutoDAO produtoDAO = new ProdutoDAO(session);
            //Produto produto = new Produto();

            //umaCategoria.Nome = "Vestuario".ToUpper();
            //categoriaDao.SalvaCategoria(umaCategoria);

            //produto.Nome = "camisa".ToUpper();
            //produto.Preco = 10;
            //produto.Categoria = umaCategoria;

            //produtoDAO.SalvaProduto(produto);
            ////ITransaction transacao = session.BeginTransaction();
            ////session.Save(produto);
            ////transacao.Commit();
            //session.Close();

            Console.WriteLine("==============================================================");

            ISession session = NHibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();

            Categoria categoria = session.Load<Categoria>(1);
            IList<Produto> produtos = categoria.Produtos;

            foreach (var i in produtos)
            {
                Console.WriteLine("\n");
                Console.WriteLine("A quantidade de produtos é : {0} ",categoria.Produtos.Count);
            }           

            transacao.Commit();
            session.Close();

            Console.WriteLine("==============================================================");

            Console.Read();
        }
    }
}
