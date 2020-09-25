using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class BCalendar
    {
        public int Id { get; set; }
        public ICollection<Hold> Holds { get; set; }
    }
}
