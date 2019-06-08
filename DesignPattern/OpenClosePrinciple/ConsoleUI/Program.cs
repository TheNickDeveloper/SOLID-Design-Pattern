using OCPLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicants = new List<IPersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new CeoModel { FirstName = "Nancy", LastName = "Roman" }
            };

            var employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
