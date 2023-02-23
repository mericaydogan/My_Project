using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CompanyCRUD
{
    public class Product : Base_Class
    {
        public static List<Product> _products = new List<Product>();
        public int Product_ID { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock  {get; set; }


        public override string Create()
        {
            Product product = new Product();
            Console.WriteLine("Lutfen urunun adini giriniz :");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Lutfen urunun kac adet oldugunu  giriniz :");
            product.UnitsInStock = int.Parse(Console.ReadLine());
            product.Product_ID = _products.Count + 1;
            _products.Add(product);
            return "Urun olusturuldu...";
        }
        public override string Delete()
        {
            Console.WriteLine("Silmek istediginiz urunun ID' sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _products.RemoveAt(secim - 1);
            return "Sectiginiz urun silindi...";
        }
        public override string Read()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine($"{product.ProductName}  {product.UnitsInStock}");
            }
            return "Urunler listelendi...";
        }
        public override string Update()
        {
            Product product = new Product();
            Console.WriteLine("Lutfen degistirmek istediginiz urunun ID'sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _products.RemoveAt(secim - 1);
            Console.WriteLine("Urunun yeni adini giriniz :");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Lutfen urunun yeni adet sayisini giriniz :");
            product.UnitsInStock = int.Parse(Console.ReadLine());
            product.Product_ID = secim - 1;
            _products.Add(product);
            return "Urun guncellendi...";
        }
    }
}
