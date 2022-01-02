using EvenTo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenTo.Controllers
{
    public class EventController : Controller
    {
        private EventRepository _eventRepository = null;
        public EventController()
        {
            _eventRepository = new EventRepository();
        }
        public ViewResult getAllEvents()
        {
            var data = _eventRepository.getAllEvents();
            return View(data);
        }

        public ViewResult viewEvent(int id)
        {
            var data = _eventRepository.getEvent(id);
            return View(data);
        }
    }
}
