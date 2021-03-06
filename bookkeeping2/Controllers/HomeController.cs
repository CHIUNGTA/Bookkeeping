﻿using bookkeeping2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bookkeeping2.Controllers
{
    public class HomeController : Controller
    {
        skilltreemodel db = new skilltreemodel();
        public ActionResult Index()
        {
            //Random ran = new Random();
            //var model = new List<Myclass>();
            //Myclass note;
            //for (int i = 0; i <= 199; i++)
            //{
            //    note = new Myclass();
            //    int randnumber = ran.Next(2);
            //    if (randnumber == 1)
            //    {
            //        note.Type = "支出";                           //隨機產生資料至Myclass_model
            //    }
            //    else
            //    {
            //        note.Type = "收入";
            //    }
            //    note.Date = DateTime.Now.AddDays(ran.Next(3650));
            //    note.Money = ran.Next(10000);
            //    model.Add(note);
           
            //var model = new List<Myclass>();
            //Myclass ram;
            //foreach(var i in db.AccountBook.ToList())
            //{
            //    ram= new Myclass();
            //    //string[] talk;
            //    //talk = i.Remarkkk.Split('5');
            //    //var talk1 = "";
            //    //foreach (var text in talk)
            //    //{
            //    //    talk1 += text;
            //    //}
            //    //ram.Remarks = (i.Remarkkk).Substring(0,10);
            //    //if (i.Remarkkk.Length == 0)
            //    //{
            //    //    ram.Remarks = "邱炯達";
            //    //}
            //    //ram.Remarks = i.Remarkkk.Substring(0,4);
            //    ram.Money = i.Amounttt.ToString("#,000");
            //    ram.Date = i.Dateee.ToString("yyyy-MM-dd hh時mm分");
            //    ram.Id = i.Id;
            //    var 類型 = "";
            //    if (i.Categoryyy != 0)
            //    {
            //        類型 = "收入";
            //    }
            //    else
            //    {
            //        類型 = "支出";
            //    }
            //    ram.Type = 類型.ToString();
            //    ram.Remarks =(i.Remarkkk.Length>3)? i.Remarkkk.Substring(0,3):"我是地雷";
            //    model.Add(ram);
            //    }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountBook)
        {
            if (ModelState.IsValid)
            {
                accountBook.Id = Guid.NewGuid();
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountBook);
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
        public ActionResult Ans()
        {
            var model = new List<Myclass>();
            Myclass ram;
            foreach (var i in db.AccountBook.ToList())
            {
                ram = new Myclass();
                //string[] talk;
                //talk = i.Remarkkk.Split('5');
                //var talk1 = "";
                //foreach (var text in talk)
                //{
                //    talk1 += text;
                //}
                //ram.Remarks = (i.Remarkkk).Substring(0,10);
                //if (i.Remarkkk.Length == 0)
                //{
                //    ram.Remarks = "邱炯達";
                //}
                //ram.Remarks = i.Remarkkk.Substring(0,4);
                ram.Money = i.Amounttt.ToString("#,000");
                ram.Date = i.Dateee.ToString("yyyy-MM-dd hh時mm分");
                ram.Id = i.Id;
                var 類型 = "";
                if (i.Categoryyy != 0)
                {
                    類型 = "收入";
                }
                else
                {
                    類型 = "支出";
                }
                ram.Type = 類型.ToString();
                ram.Remarks = (i.Remarkkk.Length > 3) ? i.Remarkkk.Substring(0, 3) : "我是地雷";
                model.Add(ram);
            }
            return View(model);
        }
    }
}