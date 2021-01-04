using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationOfMember.Business.Abstract;
using RegistrationOfMember.Entities.Concrete;
using RegistrationOfMember.MvcWebUI.Models;

namespace RegistrationOfMember.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: Member
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }
        [HttpPost]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);
            return View(new MemberAddViewModel());
        }
    }
}