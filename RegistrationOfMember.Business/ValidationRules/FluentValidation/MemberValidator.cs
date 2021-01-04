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
            RuleFor(m => m.FirstName).NotEmpty().WithMessage("'Ad' alanı boş olmamalı.");
            RuleFor(m => m.LastName).NotEmpty().WithMessage("'Soyad' alanı boş olmamalı."); ;
            RuleFor(m => m.TcNo).Length(11).NotEmpty().WithMessage("'TC kimlik numarası' alanı boş olmamalı."); ;
            RuleFor(m => m.Email).EmailAddress().NotEmpty().WithMessage("'Email' alanı boş olmamalı."); ;
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now).NotEmpty().WithMessage("'Doğum Tarihi' alanı boş olmamalı."); ;

       
        }
    }
}
