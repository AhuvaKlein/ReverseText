using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _482019.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReverseText(string text)
        {
            string s= ReverseTextString(text);
            return Json(s, JsonRequestBehavior.AllowGet);
        }

        public string ReverseTextString(string text)
        {
            string s = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                s += text[i];
            }

            return s;
        }

    }
}