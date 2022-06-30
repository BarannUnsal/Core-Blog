using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDome.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private BlogManager blogManager;
        private CategoryManager categoryManager;

        public BlogController(BlogManager blogManager, CategoryManager categoryManager)
        {
            this.blogManager = blogManager;
            this.categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            var values = blogManager.GetBlogWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            var values = blogManager.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values = blogManager.GetListWithCategoryByWriterBm();
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValue = (from x in categoryManager.GetAllList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.categoryManager = categoryValue;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidations validations = new BlogValidations();
            ValidationResult result = validations.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.BlogID = 1;
                blogManager.Add(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = blogManager.GetById(id);
            blogManager.Remove(blogValue);
            return RedirectToAction("BlogListWithWriter");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = blogManager.GetById(id);
            List<SelectListItem> categoryValue = (from x in categoryManager.GetAllList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            return View(blogValue);
        }

        [HttpPut]
        public IActionResult EditBlog(Blog blog)
        {
            blogManager.Update(blog);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
