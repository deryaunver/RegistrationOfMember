using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.Abstract
{
   public  interface IMemberService
   {
       void Add(Member member);
   }
}
