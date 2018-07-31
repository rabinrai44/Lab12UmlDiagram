using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.Library
{
    public class Staff : Person
    {
        private string _school;
        private double _pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            _school = school;
            _pay = pay;
        }

        public override string ToString()
        {
            return $"{GetName()}, {GetAddress()}, {_school}, {_pay}";
        }
    }
}
