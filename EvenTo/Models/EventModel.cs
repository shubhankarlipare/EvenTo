using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenTo.Models
{
    public class EventModel
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescritption { get; set; }
        public string EventLocation { get; set; }
        public string EventRate { get; set; }
        public string ImagePath { get; set; }
    }
}
