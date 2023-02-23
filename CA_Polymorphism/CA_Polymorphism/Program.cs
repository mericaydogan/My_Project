using System;

namespace CA_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kedi isminde bir class olusturun. Kopek isminde bir class olusturun. Yilan isminde bir class olusturun.
            //properties ve ses cikar.
            
            //Polymorphism
            //Bir metodun ya da bir property nin farkili siniflarda farkli etkiler olusturulmasini saglar.

            
            Kopek kopek = new Kopek();
            Kedi kedi= new Kedi();
            Yilan yilan = new Yilan();

            kopek.Cins = "BullDog";
            kopek.Kilo = 5;
            kopek.EvcilVahsi = true;

            kedi.Cins = "British Shothair";
            kedi.Kilo = 4.80;
            kedi.EvcilVahsi = true;

            yilan.Cins = "Kobra";
            yilan.Kilo = 4.6;
            yilan.EvcilVahsi = false;


            int secim = 0;

            Console.WriteLine("Lutfen hayvan seciniz... \n 1-Kopek \n 2-Kedi \n 3-Yilan");
            secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                kopek.SesCikar();
            }
            else if (secim == 2)
            {
                kedi.SesCikar();
            }
            else if (secim == 3)
            {
                yilan.SesCikar();
            }
            else
            {
                Console.WriteLine("Bir sorun ile karsilasildi...");
            }
        }
    }
}
