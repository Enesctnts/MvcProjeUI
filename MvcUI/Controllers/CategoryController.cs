﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        CategoryManager categoryManager = new CategoryManager();

        public ActionResult GetCategoryList()
        {
            var categoryvalues = categoryManager.GetAll();
            return View(categoryvalues);
        }


        [HttpGet]// sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]// butona tıklandıgında alttaki metod çalışacak
        public ActionResult AddCategory(Category category)
        {
            categoryManager.CategoryAddBl(category);
            return RedirectToAction("GetCategoryList");
        }

    }
}