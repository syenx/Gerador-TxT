using System.Collections.Generic;
using System.Web.Mvc;
using TextGenerator.Models;
using TextGeneratePersistence;
using TextGenerator.BO;

namespace TextGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TransacaoEntity entity) => View();

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<TransacaoModel> ConverterParaModel( IList<TransacaoEntity> list)
        {
            var models = new List<TransacaoModel>();
            var itemModel = new TransacaoModel();
            foreach (var item in list)
            {
                itemModel.IdTransacao = item.IdTransacao;
                itemModel.Cartao = item.Cartao;
                itemModel.Valor = item.Valor;
                itemModel.Data= item.Data;

                models.Add(itemModel);
            }
            return models;
            
        }
    }
}