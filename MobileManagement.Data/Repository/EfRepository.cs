using MobileManagement.Data.Db;
using MobileManagement.Data.Model;
using MobileManagement.Data.ViewModel;
using System.Collections.Generic;
using MobileManagement.Data.Helper;
using System.Linq;
using System.Data.Entity;

namespace MobileManagement.Data.Repository
{
    public class EfRepository : IRepository
    {
        private MobileManagementContext _db;

        public EfRepository(MobileManagementContext db)
        {
            _db = db;            
        }

        #region Users
        public List<UserTypeVM> GetAllUserTypes()
        {
            List<UserTypeVM> resultList = new List<UserTypeVM>();
            resultList.Add(new UserTypeVM()
            {
                Id = (int)UserType.Direktor,
                Name = "Direktor"
            });
            resultList.Add(new UserTypeVM()
            {
                Id = (int)UserType.Djelatnik,
                Name = "Djelatnik"
            });
            resultList.Add(new UserTypeVM()
            {
                Id = (int)UserType.Voditelj,
                Name = "Voditelj"
            });

            return resultList;
        }
        
        public List<UserVM> GetAllUsers()
        {
            return _db.Users
                .Select(x => new UserVM()
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,                    
                    Email = x.Email,
                    Id = x.Id,
                    UserType = x.UserType.ToString()
                })
                .ToList();            
        }

        public UserType GetUserTypeForUserId(int userId)
        {
            return _db.Users.Where(x => x.Id == userId).Select(x => x.UserType).FirstOrDefault();
        }

        public UserVM GetUserVMById(int userId)
        {
            return _db.Users
                .Select(x => new UserVM()
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Id = x.Id,
                    UserType = x.UserType.ToString()
                })
                .Where(x => x.Id == userId)
                .FirstOrDefault();
        }

        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void EditUser(User user)
        {
            //Dohvati starog usera iz baze
            var oldUser = _db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (oldUser == null)
            {
                Logging.Logger.Instance.LogError($"User with id {user.Id} not found");
                return;
            }

            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            oldUser.Email = user.Email;
            oldUser.UserType = user.UserType;

            _db.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var oldUser = _db.Users.Where(x => x.Id == userId).FirstOrDefault();
            if (oldUser == null)
            {
                Logging.Logger.Instance.LogError($"User with id {userId} not found");
                return;
            }

            _db.Users.Remove(oldUser);
            _db.SaveChanges();
        }

        public List<UserVM> GetAllPotentialUsersForDevicePrice(decimal price)
        {
            var minimumUserType = price.GetMinimumUserType();
            return _db.Users
                .Where(x => (int)x.UserType >= (int)minimumUserType)
                .Select(x => new UserVM()
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Id = x.Id,
                    UserType = x.UserType.ToString()
                })
                .ToList();
        }

        #endregion

        #region Devices
        public List<DeviceVM> GetAllDevicesForUser(int userId)
        {
            return _db.Devices
                .Include(x => x.Manufacturer)
                .Where(x => x.UserId == userId)
                .Select(x => new DeviceVM()
                {
                    Imei = x.Imei,
                    Model = x.Model,
                    PhoneNumber = x.PhoneNumber,
                    Id = x.Id,
                    Price = x.Price,
                    ManufacturerName = x.Manufacturer.Name
                })
                .ToList();
        }

        public List<DeviceVM> GetAllDevices()
        {
            // Proci po svakom uređaju i dohvatiti pripadajućeg korisnika i proizvođača

            var devices = _db.Devices
                .Include(x => x.User)
                .ToList();
            var resultList = new List<DeviceVM>();

            foreach (var device in devices)
            {
                DeviceVM vm = new DeviceVM()
                {
                    Imei = device.Imei,
                    Model = device.Model,
                    PhoneNumber = device.PhoneNumber,
                    Id = device.Id,
                    Price = device.Price,
                    ManufacturerName = device.Manufacturer.Name
                };

                if (device.UserId.HasValue)
                {
                    vm.UserName = device.User.FirstName + " " + device.User.LastName;
                }

                resultList.Add(vm);
            }

            return resultList;
        }

        public DeviceVM GetDeviceVMById(int deviceId)
        {
            var device = _db.Devices.Where(x => x.Id == deviceId).FirstOrDefault();
            if(device == null)
            {
                //Log something
                return null;
            }

            DeviceVM vm = new DeviceVM()
            {
                Imei = device.Imei,
                Model = device.Model,
                PhoneNumber = device.PhoneNumber,
                Id = device.Id,
                Price = device.Price,
                ManufacturerName = device.Manufacturer.Name,
                ManufacturerId = device.ManufacturerId
            };

            if (device.UserId.HasValue)
            {
                vm.UserId = device.UserId;
                vm.UserName = device.User.FirstName + " " + device.User.LastName;
            }

            return vm;
        }
                       
        public void AddDevice(Device device)
        {
            _db.Devices.Add(device);
            _db.SaveChanges();
        }
        
        public void EditDevice(Device device)
        {
            //Dohvati stari device iz baze
            var oldDevice = _db.Devices.Where(x => x.Id == device.Id).FirstOrDefault();
            if (oldDevice == null)
            {
                Logging.Logger.Instance.LogError($"Device with id {device.Id} not found");

                return;
            }

            oldDevice.Model = device.Model;
            oldDevice.Imei = device.Imei;
            oldDevice.UserId = device.UserId;
            oldDevice.ManufacturerId = device.ManufacturerId;
            oldDevice.Price = device.Price;

            _db.SaveChanges();
        }
        
        public void DeleteDevice(int deviceId)
        {
            var oldDevice = _db.Devices.Where(x => x.Id == deviceId).FirstOrDefault();
            if (oldDevice == null)
            {
                Logging.Logger.Instance.LogError($"Device with id {deviceId} not found");
                return;
            }

            _db.Devices.Remove(oldDevice);
            _db.SaveChanges();
        }

        #endregion

        #region Manufacturer
        public List<Manufacturer> GetAllManufacturers()
        {
            return _db.Manufacturers.ToList();
        }

        public Manufacturer GetManufacturerById(int manufacturerId)
        {
            var manufacturer = _db.Manufacturers.Where(x => x.Id == manufacturerId).FirstOrDefault();
            if (manufacturer == null)
            {
                //Log something
                return null;
            }

            return manufacturer;
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            _db.Manufacturers.Add(manufacturer);
            _db.SaveChanges();
        }

        public void EditManufacturer(Manufacturer manufacturer)
        {
            //Dohvati starog manufacturera iz baze
            var oldManufacturer = _db.Manufacturers.Where(x => x.Id == manufacturer.Id).FirstOrDefault();
            if (oldManufacturer == null)
            {
                Logging.Logger.Instance.LogError($"Manufacturer with id {manufacturer.Id} not found");

                return;
            }

            oldManufacturer.Name = manufacturer.Name;

            _db.SaveChanges();
        }

        public void DeleteManufacturer(int manufacturerId)
        {
            var oldManufacturer = _db.Manufacturers.Where(x => x.Id == manufacturerId).FirstOrDefault();
            if (oldManufacturer == null)
            {
                Logging.Logger.Instance.LogError($"Manufacturer with id {manufacturerId} not found");
                return;
            }

            _db.Manufacturers.Remove(oldManufacturer);
            _db.SaveChanges();
        }
        #endregion
    }
}
