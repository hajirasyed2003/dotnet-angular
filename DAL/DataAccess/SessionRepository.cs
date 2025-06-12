using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Models;

namespace EventDb.DAL.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly EventDbContext _context;

        public SessionRepository(EventDbContext context)
        {
            _context = context;
        }

        public List<SessionInfo> GetSessionsByEventId(int eventId)
        {
            return _context.Sessions.Where(s => s.EventId == eventId).ToList();
        }
    }
}