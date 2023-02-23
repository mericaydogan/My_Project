using System;

namespace CA_CompanyCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Yapmak istediginiz islemi seciniz \n 1.Create \n 2.Delete \n 3.Listele \n 4.Guncelle");
                int secim = int.Parse(Console.ReadLine());
                Category category = new Category();

                if(secim == 1)
                {
                    Console.WriteLine(category.Create());
                }

                else if (secim == 2)
                {
                    Console.WriteLine(category.Delete());
                }

                else if (secim == 3)
                {
                    Console.WriteLine(category.Read());
                }

                else if (secim == 4)
                {
                    Console.WriteLine(category.Update());
                }
            }
        }
    }
}
