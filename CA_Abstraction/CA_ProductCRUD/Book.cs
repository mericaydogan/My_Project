using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    public abstract class Book:Category
    {
        public int Pages { get; set; }
        public string Author { get; set; }
    }
}
