using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            DateTime date = new DateTime(1999, 05, 1);

            Company KrustyKrab = new Company("Krusty Krab", date);

            // Create three employees
            Employee spongebob = new Employee()
            {
                FirstName = "Spongebob",
                LastName = "SquarePants",
                Title = "Fry Cook",
                StartDate = new DateTime(1999, 06, 01)
            };

            Employee squidward = new Employee()
            {
                FirstName = "Squidward",
                LastName = "Tentacles",
                Title = "Cashier",
                StartDate = new DateTime(1999, 06, 01)
            };

            Employee krabs = new Employee()
            {
                FirstName = "Eugene",
                LastName = "Krabs",
                Title = "Boss",
                StartDate = new DateTime(1999, 01, 01)
            };

            List<Employee> assignEmployees = new List<Employee>()
            {
                spongebob, squidward, krabs
                
            };

            // Assign the employees to the company
            //set current employees property to be equal to assign employees list
            KrustyKrab.CurrentEmployees = assignEmployees;

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employee person in KrustyKrab.CurrentEmployees)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} works for the Krusty Krab as the {person.Title}");
            }
        }
    }
}

