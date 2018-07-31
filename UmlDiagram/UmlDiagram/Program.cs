using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDiagram.Library;

namespace UmlDiagram
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> peoples = new List<Person>();

            new Student("Rabin", "101 wingate", "C#.Net Bootcamp", 2018, 9875.60);
            new Student("Sean A", "210 Wingate", "C#.Net Bootcamp", 2018, 9855.65);

           

            foreach(Person people in peoples)
            {
                Console.WriteLine($"{people}");
            }

            Console.ReadKey();
        }
    }
}
