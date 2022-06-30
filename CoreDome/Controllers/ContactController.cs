using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDome.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager;

        public ContactController(ContactManager contactManager)
        {
            this.contactManager = contactManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;
            contactManager.Add(contact);
            return RedirectToAction("Index", "Blog");
        }
    }
}
