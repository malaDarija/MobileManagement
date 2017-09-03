using MobileManagement.Data.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Data.Helper
{
    public static class DecimalHelper
    {
        public static UserType GetMinimumUserType(this decimal price)
        {
            if(price > 0 && price <= 1000)
            {
                return UserType.Djelatnik;
            }
            else if(price > 1000 && price <= 2000)
            {
                return UserType.Voditelj;
            }
            else
            {
                return UserType.Direktor;
            }
        }
    }
}
