using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Data.Model
{
    [Table("Devices")]
    public class Device
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Imei { get; set; }
        public int UserId { get; set; }
        public int ManufacturerId { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("ManufacturerId")]
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
