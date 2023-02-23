using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CompanyCRUD
{
    public class Shipper : Base_Class
    {
        public static List<Shipper> _shippers = new List<Shipper>();
        public int Shipper_ID { get; set; }
        public string ShipperName { get; set; }
        public string ShipperRegion { get; set; }

        public override string Create()
        {
            Shipper shipper = new Shipper();
            Console.WriteLine("Lutfen nakliyeci adini giriniz :");
            shipper.ShipperName = Console.ReadLine();
            Console.WriteLine("Lutfen nakliye bolgesini giriniz :");
            shipper.ShipperRegion = Console.ReadLine();
            shipper.Shipper_ID = _shippers.Count + 1;
            _shippers.Add(shipper);
            return "Musteri olusturuldu...";
        }
        public override string Delete()
        {
            Console.WriteLine("Silmek istediginiz nakliyecinin ID' sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _shippers.RemoveAt(secim - 1);
            return "Sectiginiz musteri silindi...";
        }
        public override string Read()
        {
            foreach (Shipper shipper in _shippers)
            {
                Console.WriteLine($"{shipper.ShipperName}  {shipper.ShipperRegion}");
            }
            return "Nakliyeciler listelendi...";
        }
        public override string Update()
        {
            Shipper shipper = new Shipper();
            Console.WriteLine("Lutfen degistirmek istediginiz nakliyecinin ID'sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _shippers.RemoveAt(secim - 1);
            Console.WriteLine("Nakliyecinin yeni adini giriniz :");
            shipper.ShipperName = Console.ReadLine();
            Console.WriteLine("Lutfen nakliyecinin yeni bolgesini giriniz :");
            shipper.ShipperRegion= Console.ReadLine();
            shipper.Shipper_ID = secim - 1;
            _shippers.Add(shipper);
            return "Naklyeci guncellendi...";
        }
    }
}
