using Loja.DAO;
using Loja.INFRA;
using Loja.Model;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;
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

            //ISession session = NHibernateHelper.AbreSession();
            //ITransaction transacao = session.BeginTransaction();

            //Categoria categoria = session.Load<Categoria>(1);
            //IList<Produto> produtos = categoria.Produtos;

            //foreach (var i in produtos)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("A quantidade de produtos é : {0} ",categoria.Produtos.Count);
            //}           

            //transacao.Commit();
            //session.Close();

            Console.WriteLine("==============================================================");

            //ISession sessao = NHibernateHelper.AbreSession();

            //string hql = "from Produto p order by p.Nome";
            //IQuery query = sessao.CreateQuery(hql);
            //IList<Produto> produtos = query.List<Produto>();

            //Console.WriteLine("\n");
            //foreach (var produto in produtos)
            //{
            //    Console.WriteLine(produto.Nome);
            //}

            //Console.WriteLine("\n");
            Console.WriteLine("Com a condição Where \n");

            //string hql1 = "from Produto p where p.Preco > :valor order by p.Nome";
            //query = sessao.CreateQuery(hql1);
            //query.SetParameter("valor", 50);
            //produtos = query.List<Produto>();

            //Console.WriteLine("\n");
            //foreach (var produto in produtos)
            //{
            //    Console.WriteLine(produto.Nome + " " + produto.Preco);
            //}

            //Console.WriteLine("\n");
            Console.WriteLine("Com a condição Where e buscando a categoria \n");

            //string hql2 = "from Produto p where p.Preco > :valor1 and p.Categoria.Nome = :categoria order by p.Nome";
            //query = sessao.CreateQuery(hql2);            
            //query.SetParameter("valor1", 10);
            //query.SetParameter("categoria", "Vestuario");
            //produtos = query.List<Produto>();

            //Console.WriteLine("\n");
            //foreach (var produto in produtos)
            //{
            //    Console.WriteLine(produto.Nome + " " + produto.Preco + " " + produto.Categoria.Nome);
            //}

            Console.WriteLine("==============================================================");

            //ISession sessao = NHibernateHelper.AbreSession();

            Console.WriteLine("buscar categoria e quantos produtos estão associados a categoria \n");
            //Console.WriteLine("\n");

            //string hql = "select c as Categoria, count(p) " +
            //               "from Produto p " +
            //               "join p.Categoria c " +
            //           "group by c.Id, c.Nome";

            ////string hql = "select p.Categoria, count(p) from Produto p group by p.Categoria";
            //IQuery q = sessao.CreateQuery(hql);
            //IList<Object[]> resultados = q.List<Object[]>();

            //IList<ProdutosPorCategoria> relatorio = new List<ProdutosPorCategoria>();

            //Console.WriteLine("\n");
            //foreach (Object[] resultado in resultados)
            //{
            //    ProdutosPorCategoria p = new ProdutosPorCategoria();
            //    p.Categoria = (Categoria)resultado[0];
            //    p.NumeroDePedidos = (long)resultado[1];

            //    relatorio.Add(p);
            //}

            Console.WriteLine("==============================================================");

            //ISession sessao = NHibernateHelper.AbreSession();

            //string hql = "select Categoria as Categoria, count(p) as NumeroDePedidos from Produto p join p.Categoria group by Categoria.Id, Categoria.Nome";
            //IQuery query = sessao.CreateQuery(hql);
            //query.SetResultTransformer(Transformers.AliasToBean<ProdutosPorCategoria>());

            //IList<ProdutosPorCategoria> relatorio = query.List<ProdutosPorCategoria>();

            //sessao.Close();      

            Console.WriteLine("==============================================================");

            //ISession session = NHibernateHelper.AbreSession();

            //IQuery query = session.CreateQuery("from Produto p join fetch p.Categoria where p.Categoria = :valor");
            //query.SetParameter("valor", 1);
            //IList<Produto> produtos = query.List<Produto>();

            //foreach (var produto in produtos)
            //{
            //    Console.WriteLine(produto.Nome + " - " + produto.Categoria.Nome);
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Categoria");

            //query = session.CreateQuery("select distinct c from Categoria c join fetch c.Produtos");
            //IList<Categoria> categorias = query.List<Categoria>();

            //foreach (var categoria in categorias)
            //{
            //    Console.WriteLine(categoria.Nome + " - " + categoria.Produtos.Count);
            //}

            Console.WriteLine("==============================================================");

            Console.WriteLine("Buscas dinâmicas com Criteria");
            Console.WriteLine("\n");

            //ISession session = NHibernateHelper.AbreSession();
            //ProdutoDAO produtoDAO = new ProdutoDAO(session);

            //IList<Produto> produtos = produtoDAO.BuscaPorNomePrecoMinimoECategoria("", 12, "");

            //Console.WriteLine("\n");
            //foreach (var produto in produtos)
            //{
            //    Console.WriteLine("Produto {0}       Preço {1}        Categoria {2} \n", produto.Nome, produto.Preco, produto.Categoria.Nome);
            //}

            //session.Close();

            Console.WriteLine("==============================================================");
            Console.WriteLine("Buscas caches");

            //ISession session = NHibernateHelper.AbreSession();
            //ISession session2 = NHibernateHelper.AbreSession();

            //Categoria c = session.Get<Categoria>(1);
            //Categoria c2 = session2.Get<Categoria>(1);

            //Console.WriteLine(c.Produtos.Count);
            //Console.WriteLine(c2.Produtos.Count);

            //Console.WriteLine("\n");
            //Console.WriteLine("Usuário \n");

            //session.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();
            //session2.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();

            //session.Close();
            //session2.Close();

            Console.WriteLine("==============================================================");
            Console.WriteLine("Buscas caches");

            //NHibernateHelper.GeraSchema();
            //ISession session = NHibernateHelper.AbreSession();
            //ITransaction transacao = session.BeginTransaction();

            //Venda venda = new Venda();
            //Usuario Cliente = session.Get<Usuario>(1);


            //venda.Cliente = Cliente;

            //Produto p1 = session.Get<Produto>(1);
            //Produto p2 = session.Get<Produto>(1);


            //venda.Produtos.Add(p1);
            //venda.Produtos.Add(p2);

            //session.Save(venda);

            //transacao.Commit();
            //session.Close();

            Console.WriteLine("==============================================================");
            Console.WriteLine("Criação tabela com herança");

            //NHibernateHelper.GeraSchema();

            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            pf.Nome = "João";
            pf.CPF = "08965325698";

            pj.Nome = "alura";
            pj.CNPJ = "023658965/77";

            ISession session = NHibernateHelper.AbreSession();
            UsuarioDAO usuarioDao = new UsuarioDAO(session);

            usuarioDao.Adiciona(pf);
            usuarioDao.Adiciona(pj);

            session.Close();
            Console.Read();            
        }
    }

    public class ProdutosPorCategoria
    {
        public Categoria Categoria { get; set; }
        public long NumeroDePedidos { get; set; }
    }
}
