using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            List<Student> students = new List<Student>
            {
                new Student("Rabin", "1200 wingate DR", "C#.NET Bootcamp", 2018, 10000.05),
                new Student("Sean A", "102 William Ave SE", "C#.NET Bootcamp", 2018, 10000.00),
            };

            foreach(Student student in students)
            {
                Console.WriteLine(student);
            }

            List<Staff> staffs = new List<Staff>
            {
                new Staff("John H", "40 Pearl St", "Grand Circus", 520.4)
            };

            foreach(Staff staff in staffs)
            {
                Console.WriteLine("Staff Information\n----------------------------------------");
                Console.WriteLine(staff);
            }

            Console.ReadKey();
        }
    }
}
