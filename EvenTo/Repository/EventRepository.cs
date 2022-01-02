using EvenTo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenTo.Repository
{
    public class EventRepository
    {
        public EventModel getEvent(int id)
        {
            return DataSource().Where(x => x.EventId == id).FirstOrDefault();
        }
        public List<EventModel> getAllEvents()
        {
            return DataSource(); ;
        }
        private List<EventModel> DataSource()
        {
            return new List<EventModel>()
            {
                new EventModel(){EventId = 1, EventName = "Birthday", EventDescritption = "Time- 1hr, Cake cutting, DJ, Dinner.", EventLocation = "Mumbai/Pune", EventRate = "Rs. 15000/-", ImagePath = "/images/Birthday.jpg"},
                new EventModel(){EventId = 2, EventName = "Marriage", EventDescritption = "Time- 1hr, Cake cutting, DJ, Dinner.", EventLocation = "Mumbai/Pune", EventRate = "Rs. 40000/-", ImagePath = "/images/Marriage.jpg"},
                new EventModel(){EventId = 3, EventName = "Anniversary", EventDescritption = "Time- 1hr, Cake cutting, DJ, Dinner.", EventLocation = "Mumbai/Pune", EventRate = "Rs. 30000/-", ImagePath = "/images/anniversary.jpg"},
                new EventModel(){EventId = 4, EventName = "Reception", EventDescritption = "Time- 1hr, Cake cutting, DJ, Dinner.", EventLocation = "Mumbai/Pune", EventRate = "Rs. 20000/-", ImagePath = "/images/reception.jpg"},
                new EventModel(){EventId = 5, EventName = "Corporate Party", EventDescritption = "Time- 1hr, Cake cutting, DJ, Dinner.", EventLocation = "Mumbai/Pune", EventRate = "Rs. 150000/-", ImagePath = "/images/corporateParty.jpg"},

            };
        }
    }
}
