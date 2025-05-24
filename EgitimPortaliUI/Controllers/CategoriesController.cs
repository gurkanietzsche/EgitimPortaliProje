﻿using Microsoft.AspNetCore.Mvc;

namespace EgitimPortaliUI.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.CategoryId = id;
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.CategoryId = id;
            return View();
        }
    }
}