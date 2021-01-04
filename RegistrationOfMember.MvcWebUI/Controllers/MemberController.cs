using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationOfMember.Entities.Concrete;
using RegistrationOfMember.MvcWebUI.Models;

namespace RegistrationOfMember.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }
        [HttpPost]
        public ActionResult Add(Member member)
        {
            return View(new MemberAddViewModel());
        }
    }
}