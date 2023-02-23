using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Cheesecake
{
    internal class Mixer:Eylemler
    {
        public override string Al()
        {
            return "Mixer alindi.";
        }
        public override string Tak()
        {
            return "Mixer fise takildi.";
        }
        public override string Calistir()
        {
            return "Mixer calistirildi.";
        }
        public override string Dok()
        {
            return "Biskuvi mixere dokuldu.";
        }
    }
}
