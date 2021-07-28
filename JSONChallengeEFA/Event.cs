using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallengeEFA
{
   public class Event
    {
       public DateTime StartDate { get; set; }
       public DateTime EndDate { get; set; }
       public string EventTitle { get; set; }
       public int EventCapacity { get; set; }
       public double PriceOfAdmisson { get; set; }

        public Event() { }

        public Event(DateTime startDate, DateTime endDate, string eventTitle, int eventCapacity, double priceOfAdmisson)
        {
            StartDate = startDate;
            EndDate = endDate;
            EventTitle = eventTitle;
            EventCapacity = eventCapacity;
            PriceOfAdmisson = priceOfAdmisson;
        }
    }
   
}
