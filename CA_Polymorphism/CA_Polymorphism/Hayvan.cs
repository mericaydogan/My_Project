using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    public class Hayvan
    {   
        //Virtual, tanimlanan property ya da metodun miras alinan class icerisinde istege bagli sekilde ezilebilecegini temsil eder.

        public double Kilo{get; set;}
        public string Cins { get;  set; }
        public bool EvcilVahsi { get; set; }

        public virtual string SesCikar()
        {
            return "";
        }

    }
}
