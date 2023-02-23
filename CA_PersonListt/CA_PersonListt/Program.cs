using System;
using System.Collections.Generic;

namespace CA_PersonListt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personlist adinda bir class tanimlayarak ardindan 3 adet person olusturup bu personlari bir liste icerisinde saklayin.
            // console.writeline icerisinde person in bulundugu butun bilgilerini gosterin.

            Personel person1 = new Personel();
            person1.FirstName = "Emir";
            person1.LastName = "Guven";
            person1.Department = "Satis";

            Personel person2 = new Personel();
            person2.FirstName = "Eren";
            person2.LastName = "Guvercin";
            person2.Department = "Gelistirme";

            Personel person3 = new Personel();
            person3.FirstName = "Murat";
            person3.LastName = "kara";
            person3.Department = "Muhasebe";

            


               


        }  
    }
}
