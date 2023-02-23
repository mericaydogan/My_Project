using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CompanyCRUD
{
    public class Customer : Base_Class
    {   
        public static List<Customer> _customers = new List<Customer>();
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }  
        public string CustomerCountry { get; set; }

        public override string Create()
        {
            Customer customer = new Customer();
            Console.WriteLine("Lutfen musterinin adini giriniz :");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Lutfen musterinin ulkesini giriniz :");
            customer.CustomerCountry = Console.ReadLine();
            customer.Customer_ID = _customers.Count + 1;
            _customers.Add(customer);
            return "Musteri olusturuldu...";
        }

        public override string Delete()
        {
            Console.WriteLine("Silmek istediginiz musterinin ID' sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _customers.RemoveAt(secim - 1);
            return "Sectiginiz musteri silindi...";
        }

        public override string Read()
        {
            foreach (Customer customer in _customers)
            {
                Console.WriteLine($"{customer.CustomerName}  {customer.CustomerCountry}");
            }
            return "Musteriler listelendi...";
        }

        public override string Update()
        {
            Customer customer = new Customer();
            Console.WriteLine("Lutfen degistirmek istediginiz musterinin ID'sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _customers.RemoveAt(secim - 1);
            Console.WriteLine("Musterinin yeni adini giriniz :");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Lutfen musterinin yeni ulkesini giriniz :");
            customer.CustomerCountry= Console.ReadLine();
            customer.Customer_ID = secim - 1;
            _customers.Add(customer);
            return "Musteri guncellendi...";
        }
    }
}
