using System;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter the employee's first name: (leave empty to exit):");
                string firstName = Console.ReadLine() ?? "";
                // Break if the user hits ENTER without typing a name
                if (firstName == "")
                {
                    break;
                }

                Console.WriteLine("Please enter the employee's last name:");
                string lastName = Console.ReadLine() ?? "";

                Console.WriteLine("Please enter the employee's ID number:");
                int id = Int32.Parse(Console.ReadLine() ?? "");

                Console.WriteLine("Please enter the employee's Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        public static List<Employee> GetFromAPI()
        {
            List<Employee> employees = new List<Employee>();
            return employees;
        }
    }
}