using Redlips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redlips.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        BronContext db = new BronContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Bron
            IEnumerable<Bron> Bron = db.Bron;
            // передаем все объекты в динамическое свойство Bron в ViewBag
            ViewBag.Bron = Bron;
            // возвращаем представление
            return View();
        }
    }
}