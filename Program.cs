using System;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    async static Task Main(string[] args) //Entry Point
    {
      List<Employee> employees = new List<Employee>();
      Console.WriteLine("Would you like to enter your own employee information? Type \"Yes\" if so, or type \"No\" if you would like auto-generate employees from the Random User Generator API.");
      string input = Console.ReadLine() ?? "";
      if (input == "Yes" || input == "yes" || input == "Y")
      {
        employees = PeopleFetcher.GetEmployees();
      }
      else if (input == "No" || input == "no" || input == "N")
      {
        employees = await PeopleFetcher.GetFromAPI();
      }
      else 
      {
        Console.WriteLine("Please try again and answer either Yes or No.");
      }
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }

  }
}