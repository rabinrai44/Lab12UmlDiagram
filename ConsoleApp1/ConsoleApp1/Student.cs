using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    public class Student : Person
    {
        public Student(string name, string address, string program, int year, double fee) :base (name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }

        private string _program { get; set; }
        private int _year { get; set; }
        private double _fee { get; set; }

        // override
        public override string ToString()
        {
            return $"{GetName()}, {GetAddress()}, {_program}, {_year}, {_fee}";
        }


    }
}
