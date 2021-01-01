﻿using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.Filters;
using WebApplication.Web.Models;

namespace WebApplication.Web.Controllers
{
    public class ExchangesController : Controller
    {
        [ServiceFilter(typeof(MyCustomActionFilter))]
        public IActionResult Show(string id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {
            var viewModel = new AddNewItemConfirmationViewModel
            {
                Id = 1,
                Name = item.Name,
            };

            return RedirectToAction("AddConfirmation");
        }

        [HttpGet]
        public IActionResult AddConfirmation()
        {
            return View();
        }
    }
}