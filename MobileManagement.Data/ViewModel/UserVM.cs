﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Data.ViewModel
{
    public class UserVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Email { get; set; }
        public string UserType { get; set; }
        public string DisplayName { get
            {
                return (FirstName + " " + LastName).Trim();
            }
        }
    }
}
