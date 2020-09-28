using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
   public class Student
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }


        public Student(Guid Id, string FirstName, string LastName)  // Constructor
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }


        public ICollection<Hold> MyProperty { get; set; }
    }
}
