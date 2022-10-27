using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoArv.model
{
    public class Kok:Person   // :Person lig med arver fra klassen Person
    {
        // specielt for kok
        private int _id;
        private string _område;

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string Område
        {
            get { return _område; }
            set { _område = value; }
        }


        // konstruktør
        public Kok():this("dummy kok","",-1,"")
        {

        }

        public Kok(string name, string tlf, int id, string område):base(name,tlf)
        {
            _id = id;
            _område = område;
        }

        // ToString
        public override string ToString()
        {
            return  $"Id={_id} Name={_name} Område={_område} Telefon={_tlf}";
        }


    }
}
