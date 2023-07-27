using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Plant:Product
    {
        public string Category;
            
        public Plant(string category, int id, double price, int count):base(id,price,count)
        {
          Category= category;
        }
    }
}
