using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDome.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreDome.Controllers
{
    public class WriterController : Controller
    {
        WriterManager writerManager;

        public WriterController(WriterManager writerManager)
        {
            this.writerManager = writerManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbar()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooter()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writerValues = writerManager.GetById(1);
            return View(writerValues);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult result = validator.Validate(writer);
            if (result.IsValid)
            {
                writerManager.Update(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage addProfileImage)
        {
            Writer writer = new Writer();
            if(addProfileImage.WriterImage != null)
            {
                var extensions = Path.GetExtension(addProfileImage.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extensions;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                addProfileImage.WriterImage.CopyTo(stream);
                writer.WriterImage = newImageName;
            }
            writer.WriterMail = addProfileImage.WriterMail;
            writer.WriterName = addProfileImage.WriterName;
            writer.Password = addProfileImage.Password;
            writer.RePassword = addProfileImage.RePassword;
            writer.WriterAbout = addProfileImage.WriterAbout;
            writer.WriterStatus = true;
            writerManager.Add(writer);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
