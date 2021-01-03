using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.Business.Abstract;
using RegistrationOfMember.Business.DependencyResolvers.Ninject;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                TcNo = "54097165142",
                FirstName = "Emrah",
                LastName = "Ünver",
                Email = "emrahunver05@gmail.com",
                DateOfBirth = new DateTime(1999,8,22)
            });
            Console.WriteLine("Added!");
            Console.ReadLine();
        }
    }
}
