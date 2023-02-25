using TableRelationCRUD.EF;
using TableRelationCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TableRelationCRUD.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product model)
        {
            //if (ModelState.IsValid) { }
            //dbinsert
            var db = new test03Entities1();
            db.Products.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }



        public ActionResult List(Product model)
        {
            var db = new test03Entities1();
            var list = db.Products.ToList();
            return View(list);
        }
    }
}