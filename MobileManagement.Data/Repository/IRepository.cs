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
    public interface IRepository
    {
        List<UserTypeVM> GetAllUserTypes();
        List<UserVM> GetAllUsers();
        UserType GetUserTypeForUserId(int userId);
        UserVM GetUserVMById(int userId);
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int userId);
        List<UserVM> GetAllPotentialUsersForDevicePrice(decimal price);
        List<DeviceVM> GetAllDevicesForUser(int userId);
        List<DeviceVM> GetAllDevices();
        DeviceVM GetDeviceVMById(int deviceId);
        void AddDevice(Device device);
        void EditDevice(Device device);
        void DeleteDevice(int deviceId);
        List<Manufacturer> GetAllManufacturers();
    }
}
