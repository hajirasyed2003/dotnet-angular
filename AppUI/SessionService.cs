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
    public class SessionService
    {
        private readonly SessionRepository _sessionRepo;

        public SessionService(SessionRepository sessionRepo)
        {
            _sessionRepo = sessionRepo;
        }

        public List<SessionInfo> GetSessionsByEventId(int eventId) => _sessionRepo.GetSessionsByEventId(eventId);
    }
}
