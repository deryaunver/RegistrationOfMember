using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationOfMember.DataAccess.Concrete.EntityFramework.Mappings;
using RegistrationOfMember.Entities.Concrete;

namespace RegistrationOfMember.DataAccess.Concrete.EntityFramework
{
     public class MemberShipContext:DbContext
    {
        public MemberShipContext()
        {
          Database.SetInitializer<MemberShipContext> (null);
        }
        public DbSet<Member>Members { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            //  modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
