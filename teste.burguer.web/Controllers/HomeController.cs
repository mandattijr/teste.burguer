using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teste.burguer.entidade;
using teste.burguer.entidade.Cozinha;
using teste.burguer.entidade.Estoque;
using teste.burguer.entidade.Padrao;
using teste.burguer.entidade.Salao;
using teste.burguer.servico;
using teste.burguer.servico.Cozinha;
using teste.burguer.servico.Estoque;
using teste.burguer.servico.Padrao;
using teste.burguer.servico.Salao;

namespace teste.burguer.web.Controllers
{
    public class HomeController : Controller
    {
        private BurguerFactory bf = new BurguerFactory();

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetCardapio()
        {
            List<Cardapio> lista = bf.CardapioGet().Todos();
            var data = lista.Select(m => new { m.Id, m.Nome}).ToList();
            return Json(new { Lista = data }, JsonRequestBehavior.AllowGet);
        }
    }
}