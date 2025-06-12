using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Repositories;
using EventDb.DAL.Models;
using System.Collections.Generic;


namespace EventDb.BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepo;

        public UserService(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public List<UserInfo> GetAllUsers() => _userRepo.GetAllUsers();
        public UserInfo AddUser(UserInfo user) => _userRepo.AddUser(user);
    }
}