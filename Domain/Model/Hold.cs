using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Hold
    {

        public Hold(Guid Id) // Constructor
        {
            this.Id = Id;
        }


        public Guid Id { get; private set; }      
    }
}
