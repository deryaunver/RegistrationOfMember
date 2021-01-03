using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.DataAccess.Abstract
{
    public interface IMemberDal:IEntityRepository<Member>
    {
    }
}
