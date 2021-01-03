using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.ServiceAdapters.Abstract
{
   public interface IKpsService
   {
       bool ValidateUser(Member member);
   }
}
