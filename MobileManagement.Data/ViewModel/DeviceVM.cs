using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Data.ViewModel
{
    public class DeviceVM
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public string Model { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Price { get; set; }
        public string ManufacturerName { get; set; }
        public string UserName { get; set; }

        public int? ManufacturerId { get; set; }
        public int? UserId { get; set; }
    }
}
