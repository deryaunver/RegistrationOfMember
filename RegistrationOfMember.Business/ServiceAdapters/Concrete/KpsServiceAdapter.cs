using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.Business.KpsServiceReference;
using RegistrationOfMember.Business.ServiceAdapters.Abstract;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.Business.ServiceAdapters.Concrete
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo), member.FirstName.ToUpper(), member.LastName.ToUpper(),
                member.DateOfBirth.Year);
        }
    }
}
