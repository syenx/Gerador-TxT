using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextGeneratePersistence;
using TextGenerator.BO;

namespace TextGenerator.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View(TransacaoBO.Consultar());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
          
           var obj = TransacaoBO.ConsultaraPorID(id);


            GeradorArquivosTxt.GerarArquivo(obj);

            return View(TransacaoBO.Consultar());
        }

        [HttpPost]
        public ActionResult IndexAll()
        {

            var obj = TransacaoBO.Consultar();


            GeradorArquivosTxt.GerarTodosArquivos(obj);

            return View(TransacaoBO.Consultar());
        }


        [HttpPost]
        public ActionResult Create(TransacaoEntity data)
        {

             TransacaoBO.Inserir(data);

            return View(TransacaoBO.Consultar());
        }

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
    }
}