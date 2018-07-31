using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    public class Person
    {
        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }

        private string _name { get; set; }
        private string _address { get; set; }


        public override string ToString()
        {
            return $"{_name}, {_address}";
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address;
        }
    }
}
