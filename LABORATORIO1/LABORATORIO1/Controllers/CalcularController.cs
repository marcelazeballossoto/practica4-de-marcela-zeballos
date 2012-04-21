using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LABORATORIO1.Models;

namespace LABORATORIO1.Controllers
{
    public class CalcularController : Controller
    {
        //
        // GET: /Calcular/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult sumar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult sumar(ARITMETICA model)
        {
           int  re = model.primero + model.segundo;
            ViewBag.resultado =re;
                
            return View();
        }
        
        public ActionResult restar()
        {
            
            return View();
        }
        [HttpPost ]
        public  ActionResult  restar(ARITMETICA  model)
        {
            int r = model.primero - model.segundo;
            ViewBag.resultado = r;
            return View();
        }
        public ActionResult multiplicar()
        {
            return View();
        }
        [HttpPost ]
        public ActionResult  multiplicar (ARITMETICA model)
        {
            int r = model.primero * model.segundo;
            ViewBag.resultado = r;
            return View();
        }
        public ActionResult dividir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult dividir(ARITMETICA model)
        {
            if (model.segundo != 0)
            {
                int r = model.primero / model.segundo;
                ViewBag.resultado = r;
                return View();
            }
            else
            {
                ViewBag.resultado = "error";
                return View();
            }
           
        }
    }
}
