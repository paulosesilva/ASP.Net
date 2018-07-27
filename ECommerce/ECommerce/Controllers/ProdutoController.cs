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
    }
}