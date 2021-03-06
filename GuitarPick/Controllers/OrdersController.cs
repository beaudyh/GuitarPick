﻿using GuitarPick.DataLayer.DataModels;
using GuitarPick.DataLayer.Interfaces;
using GuitarPick.DataLayer.Repositories;
using GuitarPick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuitarPick.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private IOrdersRepository _Repos;
        private IStateRepository _Repo;
        public OrdersController()
        {
            _Repos = new LINQOrdersRepository();
            _Repo = new StateRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_Repos.Get(User.Identity.Name).Where(p => p.username == User.Identity.Name).ToList<Orders>());
        }

        [HttpGet]
        public ActionResult EditOrder(int id)
        {
            Orders order = _Repos.Get_Edit(id);
            return View(order);
        }

        [HttpPost]
        public ActionResult EditOrder(Orders order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }
            _Repos.SaveOrders(order);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddOrder()
        { 
            OrdersModel reg = new OrdersModel();
            reg.States = _Repo.GetState();
            reg.Cart = (List<int>)HttpContext.Session["myCart"];
            if (reg.Cart == null)
            {
                reg.Cart = new List<int>();
            }
                return View(reg);
        }

        [HttpPost]
        public ActionResult AddOrder(OrdersModel order)
        {
            if (!ModelState.IsValid)
            {
                order.States = _Repo.GetState();
                return View(order);
            }
            Orders reg = new Orders();
            reg.OrderID = order.OrderID;
            reg.FirstName = order.FirstName;
            reg.LastName = order.LastName;
            reg.username = User.Identity.Name;
            reg.ProductName = "Guitar";
            reg.Qty = order.Qty;
            reg.Price = order.Price;
            reg.TotalPrice = order.TotalPrice;
            reg.Address = order.Address;
            reg.City = "Klamth Falls";
            reg.State = order.State;
            reg.Zip = order.Zip;

            _Repos.SaveOrders(reg);

            return RedirectToAction("Index");
        }
    }
}