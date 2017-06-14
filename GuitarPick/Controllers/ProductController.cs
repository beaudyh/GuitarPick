using GuitarPick.DataLayer.DataModels;
using GuitarPick.DataLayer.Interfaces;
using GuitarPick.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuitarPick.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _Repos;
        public ProductController()
        {
            _Repos = new LINQProductRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_Repos.GetList());
        }
        [Authorize]
        [HttpGet]
        public ActionResult Add()
        {
            return View(new Product());
        }
        [Authorize]
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            _Repos.Save(product);
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult AddtoCart(int ProductID)
        {
            List<int> cartItems = (List<int>)HttpContext.Session["myCart"];
            if(cartItems == null)
            {
                cartItems = new List<int>();
            }
            cartItems.Add(ProductID);
            HttpContext.Session["myCart"] = cartItems;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = _Repos.Get(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            _Repos.Save(product);
            return RedirectToAction("Index");
        }
    }
}