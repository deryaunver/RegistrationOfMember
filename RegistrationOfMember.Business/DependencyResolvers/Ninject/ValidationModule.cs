using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ninject.Modules;
using RegistrationOfMember.Business.ValidationRules.FluentValidation;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.DependencyResolvers.Ninject
{
  public  class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
