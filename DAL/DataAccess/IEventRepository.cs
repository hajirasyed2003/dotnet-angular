using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Models;


namespace EventDb.DAL.Repositories
{
    public interface IEventRepository
    {
        EventDetails AddEvent(EventDetails ev);
        EventDetails UpdateEvent(EventDetails ev);
        EventDetails DeleteEvent(int eventId);
        EventDetails GetEventById(int eventId);
        List<EventDetails> GetAllEvents();
    }
}

