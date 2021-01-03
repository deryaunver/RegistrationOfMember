using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.Business.Abstract;
using RegistrationOfMember.DataAccess.Abstract;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.Concrete
{
   public class MemberManager:IMemberService
   {
       private IMemberDal _memberDal;

       public MemberManager(IMemberDal memberDal)
       {
           _memberDal = memberDal;
       }

       public void Add(Member member)
       {
           _memberDal.Add(member);
       }
    }
}
