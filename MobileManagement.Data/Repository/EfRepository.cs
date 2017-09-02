using MobileManagement.Data.Db;
using MobileManagement.Data.Model;
using MobileManagement.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Data.Repository
{
    public class EfRepository
    {
        private MobileManagementContext _db;

        public EfRepository(MobileManagementContext db)
        {
            _db = db;
        }

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

        public List<Device> GetAllDevices()
        {
            return _db.Devices.ToList();
        }

        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void AddDevice(Device device)
        {
            _db.Devices.Add(device);
            _db.SaveChanges();
        }

        public void EditUser(User user)
        {
            //Dohvati starog usera iz baze
            var oldUser = _db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (oldUser == null)
            {
                //TODO: log something
                return;
            }

            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;            
            oldUser.Email = user.Email;
            oldUser.UserType = user.UserType;

            _db.SaveChanges();
        }

        public void EditDevice(Device device)
        {
            //Dohvati starog usera iz baze
            var oldDevice = _db.Devices.Where(x => x.Id == device.Id).FirstOrDefault();
            if (oldDevice == null)
            {
                //TODO: log something
                return;
            }

            oldDevice.Model = device.Model;
            oldDevice.Imei = device.Imei;
            oldDevice.UserId = device.UserId;
            oldDevice.ManufacturerId = device.ManufacturerId;
            oldDevice.Price = device.Price;

            _db.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var oldUser = _db.Users.Where(x => x.Id == userId).FirstOrDefault();
            if (oldUser == null)
            {
                //TODO: log something
                return;
            }

            _db.Users.Remove(oldUser);
            _db.SaveChanges();
        }

        public void DeleteDevice(int deviceId)
        {
            var oldDevice = _db.Devices.Where(x => x.Id == deviceId).FirstOrDefault();
            if (oldDevice == null)
            {
                //TODO: log something
                return;
            }

            _db.Devices.Remove(oldDevice);
            _db.SaveChanges();
        }
    }
}
