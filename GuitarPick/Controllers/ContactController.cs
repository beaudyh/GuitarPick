using GuitarPick.DataLayer;
using System;
using GuitarPick.DataLayer.Interfaces;
using GuitarPick.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuitarPick.DataLayer.DataModels;

namespace GuitarPick.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository _Repos;
        public ContactController()
        {
            _Repos = new LINQConctactRepository();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(new Contact());
        }

        [HttpPost]
        public ActionResult Add(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            _Repos.Insert(contact);
            return RedirectToAction("Add");
        }
    }
}