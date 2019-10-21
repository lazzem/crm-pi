using MyFinance.Domain.Entities;
using MyFinance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinanceWeb.Controllers
{
    public class ProductController : Controller
    {

        ServiceProduct sv = new ServiceProduct();
        // GET: Product
        public ActionResult Index()
        {
            //List<Product> Listprod = Session["Products"] as List<Product>;
            var products=sv.GetMany();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ServiceProduct pm = new ServiceProduct();
            ServiceCategory sc = new ServiceCategory();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product p)
        {
           // List<Product> Listprod = Session["Products"] as List<Product>;
           // if (Listprod==null)
          //  {
              //  Listprod = new List<Product>();
           // }
            try
            {
                // TODO: Add insert logic here
                sv.Add(p);
              //  Listprod.Add(p);
              //  Session["Products"] = Listprod;
                sv.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product p)
        {
            try
            {
                sv.Delete(p);
                sv.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
        }
    }
}
