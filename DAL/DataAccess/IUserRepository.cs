using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Models;

namespace EventDb.DAL.Repositories
{
    public interface IUserRepository
    {
        UserInfo AddUser(UserInfo user);
        List<UserInfo> GetAllUsers();
    }
}
