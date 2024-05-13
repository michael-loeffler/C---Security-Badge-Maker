using System;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    async static Task Main(string[] args) //Entry Point
    {
      // List<Employee> employees = PeopleFetcher.GetEmployees();
      List<Employee> employees = PeopleFetcher.GetFromAPI();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }

  }
}