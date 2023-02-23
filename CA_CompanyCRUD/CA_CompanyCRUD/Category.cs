using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CompanyCRUD
{
    public class Category : Base_Class
    {
        public static List<Category> _categories = new List<Category>();
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }

        public override string Create()
        {
            Category category = new Category();
            Console.WriteLine("Eklemek istediginiz kategorinin adini giriniz :");
            category.Category_Name = Console.ReadLine();
            category.Category_ID = _categories.Count+1;
            _categories.Add(category);
            return "Kategori olusturuldu...";
        }

        public override string Delete()
        {
            Console.WriteLine("Silmek istediginiz kategorinin ID' sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _categories.RemoveAt(secim-1);
            return "Sectiginiz kategori silindi...";
        }

        public override string Read()
        {
            foreach (Category category in _categories)
            {
                Console.WriteLine($"{category.Category_Name}");  
            }
            return "Kategoriler listelendi...";
        }

        public override string Update()
        {
            Category category = new Category();
            Console.WriteLine("Lutfen degistirmek istediginiz urunun ID'sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _categories.RemoveAt(secim - 1);
            Console.WriteLine("Kategorinin yeni adini giriniz :");
            category.Category_Name = Console.ReadLine();
            category.Category_ID = secim - 1;
            _categories.Add(category);
            return "Kategori guncellendi...";
        }
    }
}
