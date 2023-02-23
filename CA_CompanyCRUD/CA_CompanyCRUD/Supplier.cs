using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CompanyCRUD
{
    public class Supplier : Base_Class
    {
        public static List<Supplier> _suppliers = new List<Supplier>();
        public int Supplier_ID { get; set; }
        public string SupplierName { get; set; }

        public override string Create()
        {   
            Supplier supplier = new Supplier();
            Console.WriteLine("Eklemek istediginiz tedarikcinin adini giriniz :");
            supplier.SupplierName = Console.ReadLine();
            supplier.Supplier_ID = _suppliers.Count + 1;
            Console.WriteLine("Lutfen tedarikcinin urununu ID olarak giriniz :");
            _suppliers.Add(supplier);
            return "Tedarikci olusturuldu...";
        }
        public override string Delete()
        {
            Console.WriteLine("Silmek istediginiz tedarikcinin ID' sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _suppliers.RemoveAt(secim - 1);
            return "Sectiginiz tedarikci silindi...";
        }
        public override string Read()
        {
            foreach (Supplier supplier in _suppliers)
            {
                Console.WriteLine($"{supplier.SupplierName}");
            }
            return "Tedarikciler listelendi...";
        }
        public override string Update()
        {
            Supplier supplier = new Supplier();
            Console.WriteLine("Lutfen degistirmek istediginiz tedarikcinin ID'sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _suppliers.RemoveAt(secim - 1);
            Console.WriteLine("Tedarikcinin yeni adini giriniz :");
            supplier.SupplierName = Console.ReadLine();
            supplier.Supplier_ID = secim - 1;
            _suppliers.Add(supplier);
            return "Tedarikci guncellendi...";
        }
    }
}
