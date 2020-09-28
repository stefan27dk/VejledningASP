using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
   public class Timeslot
    {
        public Guid Id { get; private set; }
        public BCalendar BCalendar { get; private set; }

        public Timeslot(Guid Id, BCalendar BCalendar)  // Constructor
        {
            this.Id = Id;
            this.BCalendar = BCalendar;
        }

    }
}
