﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
   public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Hold> MyProperty { get; set; }
    }
}
