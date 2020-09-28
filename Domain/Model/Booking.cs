using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Booking
    {

        public Booking(Guid Id) // Constructor
        {
            this.Id = Id;
        }



        public Guid Id { get; private set; }
    }
}
