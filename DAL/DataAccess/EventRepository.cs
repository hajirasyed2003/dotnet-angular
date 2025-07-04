using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using EventDb.DAL.Models;

namespace EventDb.DAL.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventDbContext _context;

        public EventRepository(EventDbContext context)
        {
            _context = context;
        }

        public EventDetails AddEvent(EventDetails ev)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC InsertEvent @EventName, @EventCategory, @EventDate, @Description, @Status",
                new SqlParameter("@EventName", ev.EventName),
                new SqlParameter("@EventCategory", ev.EventCategory),
                new SqlParameter("@EventDate", ev.EventDate),
                new SqlParameter("@Description", ev.Description ?? ""),
                new SqlParameter("@Status", ev.Status));

            return ev;
        }

        public EventDetails UpdateEvent(EventDetails ev)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC UpdateEvent @EventId, @EventName, @EventCategory, @EventDate, @Description, @Status",
                new SqlParameter("@EventId", ev.EventId),
                new SqlParameter("@EventName", ev.EventName),
                new SqlParameter("@EventCategory", ev.EventCategory),
                new SqlParameter("@EventDate", ev.EventDate),
                new SqlParameter("@Description", ev.Description ?? ""),
                new SqlParameter("@Status", ev.Status));

            return ev;
        }

        public EventDetails DeleteEvent(int eventId)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC DeleteEvent @EventId",
                new SqlParameter("@EventId", eventId));
            return null;
        }

        public EventDetails GetEventById(int eventId)
        {
            return _context.Events.FirstOrDefault(e => e.EventId == eventId);
        }

        public List<EventDetails> GetAllEvents()
        {
            return _context.Events.ToList();
        }
    }
}
