using SudPR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudPR.Repository
{
    public class UserRepository
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserByLogin(string login)
        {
            return users.FirstOrDefault(u => u.Login == login);
        }

        public void UpdateUser(User updatedUser)
        {
            var existingUser = users.FirstOrDefault(u => u.Login == updatedUser.Login);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Password = updatedUser.Password;
                existingUser.PhoneNumber = updatedUser.PhoneNumber;
            }
        }

        public void DeleteUser(string login)
        {
            var userToRemove = users.FirstOrDefault(u => u.Login == login);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }
        }
    }
}
