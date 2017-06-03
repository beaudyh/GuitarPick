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
    public class NewsController : Controller
    {
        private INewsRepository _Repos;

        public NewsController()
        {
            _Repos = new LINQNewsRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_Repos.GetList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new News());
        }

        [HttpPost]
        public ActionResult Add(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            _Repos.Insert(news);
            return RedirectToAction("Index");
        }
    }
}