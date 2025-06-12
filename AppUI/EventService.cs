using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDb.DAL.Repositories;
using EventDb.DAL.Models;


namespace EventDb.BLL
{
    public class EventService
    {
        private readonly EventRepository _eventRepo;

        public EventService(EventRepository eventRepo)
        {
            _eventRepo = eventRepo;
        }

        public List<EventDetails> GetAllEvents() => _eventRepo.GetAllEvents();
        public EventDetails GetEventById(int id) => _eventRepo.GetEventById(id);
        public EventDetails AddEvent(EventDetails ev) => _eventRepo.AddEvent(ev);
        public EventDetails UpdateEvent(EventDetails ev) => _eventRepo.UpdateEvent(ev);
        public EventDetails DeleteEvent(int id) => _eventRepo.DeleteEvent(id);
    }
}
