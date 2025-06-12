using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Models;

namespace EventDb.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EventDbContext _context;

        public UserRepository(EventDbContext context)
        {
            _context = context;
        }

        public UserInfo AddUser(UserInfo user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public List<UserInfo> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}