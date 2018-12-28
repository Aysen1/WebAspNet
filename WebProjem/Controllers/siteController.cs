using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjem.Controllers
{
    public class siteController : Controller
    {
        public string anasayfa()
        {
            string veri = "";
            string yazi = "<h1 style='Color:Black;'>Web sitesine Hoşgeldiniz.</h1>";
            string linkler = "<a href='/site/anasayfa'>Anasayfa | </a>";
            linkler += "<a href='/site/hakkimda'>Hakkında | </a>"; 
            linkler += "<a href='/site/iletisim'>İletişim | </a>";
            veri = linkler + yazi;
            return veri;
        }
        public string hakkimda()
        {
            string bilgi = "<h1 style='color:Blue;'>Hakkında sayfasına hoşgeldiniz.</h1>";
            string linkler = "<a href='/site/anasayfa'>Anasayfa | </a>";
            linkler += "<a href='/site/hakkimda'>Hakkında | </a>";
            linkler += "<a href='/site/iletisim'>İletişim | </a>";
            string veri = "";
            veri = linkler + bilgi;
            return veri;
        }
        public string iletisim()
        {
            string sonuc = "<h1 style='Color:Green;'>İletişim sayfasındasınız.</h1>";
            string veri = "";
            string linkler = "<a href='/site/anasayfa'>Anasayfa | </a>";
            linkler += "<a href='/site/hakkimda'>Hakkında | </a>";
            linkler += "<a href='/site/iletisim'>İletişim | </a>";
            veri = linkler + sonuc;
            return veri;
        }
    }
}