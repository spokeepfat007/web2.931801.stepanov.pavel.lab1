using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class CalcServiceController : Controller
    {
        int a;
        int b;

        // GET: CalcServiceController
  
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalcServiceController/Details/5
        public ActionResult PassUsingVievData()
        {
            Random rnd = new Random();
            a = rnd.Next(11);
            b = rnd.Next(11);
            ViewData["Line1"] = "Rand Value First : " + a;
            ViewData["Line2"] = "Rand Value Second : " + b;
            ViewData["Line3"] = "Add :";
            ViewData["Line4"] = a + " + " + b + " = " + (a+b);
            ViewData["Line5"] = "Sub :";
            ViewData["Line6"] = a + " - " + b + " = " + (a - b);
            ViewData["Line7"] = "Mult :";
            ViewData["Line8"] = a + " * " + b + " = " + (a * b);
            ViewData["Line9"] = "Div :";
            ViewData["Line10"] = a + " / " + b + " = " + (b != 0 ? (a / b) : "Exception: Division by zero");
            return View();
        }

        // GET: CalcServiceController/Create
        public ActionResult PassUsingModel()
        {
            Random rnd = new Random();
            a = rnd.Next(11);
            b = rnd.Next(11);
            var viewModel = new Actions()
            {
                val1 = a,
                val2 = b,
                sub = a - b,
                mul = a * b,
                add = a + b,
                div = (b != 0 ? (a / b) : -1)
            };

            return View(viewModel);
        }
        public ActionResult PassUsingVievBag()
        {
            Random rnd = new Random();
            a = rnd.Next(11);
            b = rnd.Next(11);
            ViewBag.Line1 = "Rand Value First : " + a;
            ViewBag.Line2 = "Rand Value Second : " + b;
            ViewBag.Line3 = "Add :";
            ViewBag.Line4 = a + " + " + b + " = " + (a + b);
            ViewBag.Line5 = "Sub :";
            ViewBag.Line6 = a + " - " + b + " = " + (a - b);
            ViewBag.Line7 = "Mult :";
            ViewBag.Line8 = a + " * " + b + " = " + (a * b);
            ViewBag.Line9 = "Div :";
            ViewBag.Line10 = a + " / " + b + " = " +(b != 0 ? (a / b) : "Exception: Division by zero");
            return View();
        }
        public ActionResult AccessServiceDirectly()
        {
            return View();
        }

   
    }
}
