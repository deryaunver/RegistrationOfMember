using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationOfMember.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Add()
        {
            return View();
        }
    }
}