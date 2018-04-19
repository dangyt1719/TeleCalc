
using ITUniver.TeleCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IT_UNIVER.TeleCalc.Web.Controllers 

{
    public class CalcController : Controller
    {
        Calc calc = new Calc();
        // GET: Calc
        [HttpGet]
        public ActionResult Index(string operName, double? x1, double? y1)
        {
            Calc calc = new Calc();
            if(operName=="Operations")
            {
                ViewBag.CalcC = calc.Find();
                bool sign =true;
                ViewBag.Sign = sign;
            }
            else
            // ViewBag.CalcC = calc.Find();
            {
                ViewBag.OperName = operName;
                ViewBag.X1 = x1;
                ViewBag.Y1 = y1;
                ViewBag.E = calc.Exec(operName, x1, y1);
                ViewBag.R = x1 + y1;
                bool sign = false;
                ViewBag.Sign = sign;
            }
            
            return View();
        }
    }
}