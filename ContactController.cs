﻿using Microsoft.AspNetCore.Mvc;
using ContactsDirectory.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactsDirectory.Controllers
{
    public class ContactController : Controller
    {
        static List<ContactInfo> contacts = new List<ContactInfo>();

        public ActionResult ShowContacts()
        {
            return View(contacts);
        }

        public ActionResult GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.ContactId == id);
            if (contact == null)
                return NotFound();
            return View(contact);
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(ContactInfo contactInfo)
        {
            contactInfo.ContactId = contacts.Count > 0 ? contacts.Max(c => c.ContactId) + 1 : 1;
            contacts.Add(contactInfo);
            return RedirectToAction("ShowContacts");
        }
    }
}
