using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CompanyCRUD
{
    public class Employee : Base_Class
    {

        public static List<Employee> _employees = new List<Employee>();
        public int Employee_ID { get; set; }
        public string EmployeeName { get; set; }
        public string Employee_HomeTown { get; set; }

        public override string Create()
        {
            Employee employee = new Employee();
            Console.WriteLine("Lutfen eleman adini giriniz :");
            employee.EmployeeName = Console.ReadLine();
            Console.WriteLine("Lutfen elemanin memleketini giriniz :");
            employee.Employee_HomeTown = Console.ReadLine();
            employee.Employee_ID = _employees.Count + 1;
            _employees.Add(employee);
            return "Eleman olusturuldu...";
        }

        public override string Delete()
        {
            Console.WriteLine("Silmek istediginiz elemanin ID' sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _employees.RemoveAt(secim - 1);
            return "Sectiginiz eleman silindi...";
        }

        public override string Read()
        {
            foreach (Employee employee in _employees)
            {
                Console.WriteLine($"{employee.EmployeeName}  {employee.Employee_HomeTown}");
            }
            return "Elemanlar listelendi...";
        }

        public override string Update()
        {
            Employee employee = new Employee();
            Console.WriteLine("Lutfen degistirmek istediginiz elemanin ID'sini giriniz :");
            int secim = int.Parse(Console.ReadLine());
            _employees.RemoveAt(secim - 1);
            Console.WriteLine("Elemanin yeni adini giriniz :");
            employee.EmployeeName = Console.ReadLine();
            Console.WriteLine("Lutfen elemanin yeni memleketini giriniz :");
            employee.Employee_HomeTown= Console.ReadLine();
            employee.Employee_ID = secim - 1;
            _employees.Add(employee);
            return "Eleman guncellendi...";
        }
    }
}
