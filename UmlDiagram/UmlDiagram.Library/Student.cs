using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.Library
{
    public class Student : Person
    {
        private string _program;
        private int _year;
        private double _fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }

        public override string ToString()
        {
            return $"{GetName()}, {GetAddress()}, {_program}, {_year}, {_fee}";
        }
    }
}
