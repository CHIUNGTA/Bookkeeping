using bookkeeping2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bookkeeping2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random ran = new Random();
            var model = new List<Myclass>();
            Myclass note;
            for (int i = 0; i <= 200; i++)
            {
                note = new Myclass();
                int randnumber = ran.Next(2);
                if (randnumber == 1)
                {
                    note.Type = "支出";
                }
                else
                {
                    note.Type = "收入";
                }
                note.Date = DateTime.Now.AddDays(ran.Next(3650));
                note.Money = ran.Next(10000);
                model.Add(note);

            }

            return View(model);
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