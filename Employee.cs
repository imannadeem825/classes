using System;

namespace classes
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        // Calculated property that has no setter. It is readonly.
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}