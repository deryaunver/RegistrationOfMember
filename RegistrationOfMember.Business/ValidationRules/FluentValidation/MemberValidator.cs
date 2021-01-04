using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.ValidationRules.FluentValidation
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty().WithMessage("'Ad' alanı BOŞ GEÇİLEMEZ");
            RuleFor(m => m.LastName).NotEmpty();
            RuleFor(m => m.TcNo).Length(11).NotEmpty();
            RuleFor(m => m.Email).EmailAddress().NotEmpty();
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now).NotEmpty();

       
        }
    }
}
