using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class BCalendar
    {

        public BCalendar(Guid Id)   // Constructor
        {
            this.Id = Id;        
        }


        public Guid Id { get; private set; }                 
        public ICollection<Hold> Holds { get; set; }
    }
}
