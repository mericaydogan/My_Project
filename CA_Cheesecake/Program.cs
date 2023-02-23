using System;

namespace CA_Cheesecake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eylemler eylem = new Eylemler();
            Biskuvi biskuvi = new Biskuvi();
            Kelepceli_Kap kelepceli_Kap = new Kelepceli_Kap();
            Krema krema = new Krema();
            Kucuk__Tencere kucuk__Tencere = new Kucuk__Tencere();
            Labne labne = new Labne();
            Mixer mixer = new Mixer();
            Nisasta nisasta = new Nisasta();
            Tereyagi tereyagi = new Tereyagi();
            Un un = new Un();
            Vanilya vanilya = new Vanilya();
            Yumurta yumurta = new Yumurta();

            Console.WriteLine("Cheesecake yapma programina hosgeldiniz...");
            Console.WriteLine("Baslamak icin lutfen 'Enter' tusuna basiniz...");
            Console.Read();
            Console.WriteLine("Biskuviyi almak icin enter a basin.");
            Console.Read();
            Console.WriteLine(biskuvi.Al());
            Console.WriteLine("Mixeri almak icin enter a basin.");
            Console.Read();
            Console.WriteLine(mixer.Al());
            Console.WriteLine("Biskuviyi mixere dokmek icin enter a basin.");
            Console.Read();
            Console.WriteLine(mixer.Dok());
            Console.WriteLine("Mixeri fise takmak ve calistirmak icin enter a basin.");
            Console.Read();
            Console.WriteLine(mixer.Tak() + "\n" + mixer.Calistir());
            Console.WriteLine("Kucuk tencereyi ve tereyagini almak icin enter a bas.");
            Console.Read();
            Console.WriteLine(tereyagi.Al() +"\n"+ kucuk__Tencere.Al());
            Console.WriteLine("");
        }
    }
}
