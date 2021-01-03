using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.Business.Abstract;
using RegistrationOfMember.Business.ServiceAdapters.Abstract;
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

        public void Add(Member member)
        {
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
