using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Services.Dtos;
using Data.Entities;

namespace Services
{
    public class Service
    {

        public static DataAccess data = new DataAccess();

        //USERS

        public void CreateUserService(UserDto userDto)
        {
            var user = new User()
            {
                Username = userDto.Username,
                Password = userDto.Password
            };

            data.CreateUser(user);
        }
        
        public List<string> ReadUsersService()
        {
            return data.ReadUsers();
        }

        public void UpdateUserService(UserDto userDto)
        {
            var user = new User()
            {
                Username = userDto.Username,
                Password = userDto.Password
            };

            data.UpdateUser(user);
        }

        public void DeleteUserService(string username)
        {
            data.DeleteUser(username);
        }

        public UserDto ReadUserService(string username)
        {
            var user = data.ReadUser(username);

            return new UserDto()
            {
                Username = user.Username,
                Password = user.Password
            };
            
        }
    }
}
