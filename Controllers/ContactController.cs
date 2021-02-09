using Contacts.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacts.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactUsEntities101 obj = new ContactUsEntities101();
       public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(Contactdb model)
        {
            Contactdb cbj = new Contactdb();
            cbj.id = model.id;
            cbj.Fname = model.Fname;
            cbj.Lname = model.Lname;
            cbj.Message = model.Message;
            cbj.email = model.email;
            cbj.phoneno = model.phoneno;
            obj.Contactdbs.Add(cbj);
            obj.SaveChanges();
            ModelState.Clear();
            return View();

        }
    }
}