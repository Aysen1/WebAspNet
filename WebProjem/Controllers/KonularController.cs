using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjem.Controllers
{
    public class KonularController : Controller
    {
        public ViewResult Dersler()
        {
            return View();
        }
        public ViewResult Bolumler()
        {
            return View();
        }
    }
}