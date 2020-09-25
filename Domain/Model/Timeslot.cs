using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
   public class Timeslot
    {
        public int Id { get; set; }
        public BCalendar BCalendar { get; set; }
    }
}
