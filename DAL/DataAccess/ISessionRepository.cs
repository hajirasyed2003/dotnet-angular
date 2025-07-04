using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Models;
using System.Collections.Generic;

namespace EventDb.DAL.Repositories
{
    public interface ISessionRepository
    {
        List<SessionInfo> GetSessionsByEventId(int eventId);
    }
}