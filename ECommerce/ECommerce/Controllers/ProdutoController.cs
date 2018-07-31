using ECommerce.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class ProdutoController : Controller
    {
        Context context = new Context();
        // GET: Produto
        public ActionResult Index()
        {
            ViewBag.Data = DateTime.Now;
            ViewBag.Produtos = context.Produtos.ToList();
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string txtNome, string txtDescricao, string txtPreco, string txtCategoria)
        {
            Produto produto = new Produto
            {
                Nome = txtNome,
                Descricao = txtDescricao,
                Preco = Convert.ToDouble(txtPreco),
                Categoria = txtCategoria
            };

            context.Produtos.Add(produto);
            context.SaveChanges();

            return RedirectToAction("Index", "Produto");
        }

        public ActionResult Remover(int id)
        {
            context.Produtos.Remove(context.Produtos.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index", "Produto");
        }

        public ActionResult Alterar(int id)
        {
            ViewBag.Produto = context.Produtos.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Alterar(int produtoID, string txtNome, string txtDescricao, string txtPreco, string txtCategoria)
        {
            Produto produto = context.Produtos.Find(produtoID);
            produto.Nome = txtNome;
            produto.Descricao = txtDescricao;
            produto.Preco = Convert.ToDouble(txtPreco);
            produto.Categoria = txtCategoria;
           

            context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("Index", "Produto");
        }
    }
}