using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoArv.model
{
    public class Person
    { 
        // instans felter
        protected string _name;
        protected string _tlf;

        // properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }


        // konstruktør
        public Person():this("dummy","")
        {

        }

        public Person(string name, string tlf)
        {
            _name = name;
            _tlf = tlf;
        }

        // ToString
        public override string ToString()
        {
            return $"Name={_name} Telefon={_tlf}";
        }
    }
}
