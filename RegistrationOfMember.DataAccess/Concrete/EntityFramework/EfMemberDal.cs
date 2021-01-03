using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using RegistrationOfMember.DataAccess.Abstract;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.DataAccess.Concrete.EntityFramework
{
  public  class EfMemberDal:EfEntityRepositoryBase<Member,MemberShipContext>,IMemberDal
    {
    }
}
