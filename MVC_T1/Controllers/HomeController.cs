using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculateAndConvert;

namespace MVC_T1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.n = 1;
            ViewBag.pow = 2;
            ViewBag.accur = 1;
            ViewBag.NumberByMathPow = 1;
            ViewBag.result = SqrtCalculate.SqrtN(1, 1, 0);
            return View();
        }

        [HttpPost]
        public ActionResult Index(ValueForm value)
        {
            ViewBag.n = value.n;
            ViewBag.pow = value.pow;
            ViewBag.accur = value.accur;
            ViewBag.result = SqrtCalculate.SqrtN(value.pow, value.n, value.accur);
            ViewBag.resultMathPow = SqrtCalculate.SqrtN(value.pow, value.n, value.accur, true);
            
            if (ViewBag.result >= ViewBag.resultMathPow)
            {
                if (ViewBag.result == ViewBag.resultMathPow)
                {
                    ViewBag.sign = "=";
                }
                else
                {
                    ViewBag.sign = ">";
                }
                
            }
            else
            {
                ViewBag.sign = "<";
            }
            ViewBag.binary = ConvertBinary.getBinary(value.n);
            return View();
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