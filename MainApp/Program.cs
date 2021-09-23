using System;
using AppLibrary;
namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var data = Fetching.GetDataFromHttp().GetAwaiter().GetResult();
           var place = Searching.SearchByName(data, "Grocery Store");
           Console.WriteLine(place);
    }
}
}
