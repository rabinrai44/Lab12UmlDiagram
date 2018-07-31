using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.Library
{
    public class Person
    {
        private string _name;
        private string _address;

        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return $"{_name}";
        }

        public string GetAddress()
        {
            return $"{_address}";
        }
    }
}
