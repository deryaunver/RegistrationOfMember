using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using RegistrationOfMember.Business.Abstract;
using RegistrationOfMember.Business.ServiceAdapters.Abstract;
using RegistrationOfMember.Business.ValidationRules.FluentValidation;
using RegistrationOfMember.DataAccess.Abstract;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }
        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            if (_memberDal.Get(m=>m.TcNo==member.TcNo)!=null)
            {
                throw  new Exception("Bu Kullanıcı Sisteme Daha Önce Kayıt Olmuştur.");
            }
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kimlik Doğrulamadı!");
            }
            else
            {
                _memberDal.Add(member);
            }

        }
    }
}
