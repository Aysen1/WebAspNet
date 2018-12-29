using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjem.Controllers
{
    public class AspController : Controller
    {
        public ViewResult Anasayfa()
        {
            return View();
        }
        public ViewResult Hakkimda()
        {
            return View();
        }
        public ViewResult Konular()
        {
            return View();
        }
        public ViewResult Haberler()
        {
            return View();
        }
        public ViewResult iletisim()
        {
            return View();
        }
    }
}