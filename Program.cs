using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
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

    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
      }
    }
    static void Main(string[] args) //Entry Point
    {
      // This is our employee-getting code now
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }

  }
}