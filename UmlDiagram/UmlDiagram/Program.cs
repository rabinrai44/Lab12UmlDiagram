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
            //creating object
            var p = new Person("Rabin", "384 wingate");
            var s = new Student("Rabin Rai", "3828 wingate", "C# .NET Bootcamp", 2018, 9873.83);
            var st = new Staff("Justine Jone", "40 Pearl st", "Grand Circus", 60000.87);

            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(st);

            Console.ReadLine();

        }
    }
}
