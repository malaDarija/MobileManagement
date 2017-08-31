using MobileManagement.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Data.Db
{
    public class MobileManagementContext : DbContext
    {

        public MobileManagementContext() : base("MobileManagementContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
