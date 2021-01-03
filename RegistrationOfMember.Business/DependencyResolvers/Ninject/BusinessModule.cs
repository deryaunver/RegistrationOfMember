using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using RegistrationOfMember.Business.Abstract;
using RegistrationOfMember.Business.Concrete;
using RegistrationOfMember.Business.ServiceAdapters.Abstract;
using RegistrationOfMember.Business.ServiceAdapters.Concrete;
using RegistrationOfMember.DataAccess.Abstract;
using RegistrationOfMember.DataAccess.Concrete.EntityFramework;

namespace RegistrationOfMember.Business.DependencyResolvers.Ninject
{
  public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
