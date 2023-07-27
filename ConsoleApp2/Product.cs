using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Product
    {
        public int Id;
        public double Price;
        public int Count;
        public Product(int id, double price, int count)
        {
            Id = id;
            Price = price;
            Count = count;

        }

        public void Addbasket(int quantity)
        {
            if (quantity > Count)
            {
                Console.WriteLine($"Secdiyiniz mehsuldan qeyd etdiyiniz eded qeder yoxdur:{Count}") ;

            }
            else
            {
                Count-=quantity;
                Console.WriteLine($"mehsulun idsi;{Id}");
                Console.WriteLine($"mehsulun qiymeti;{Price}");
                Console.WriteLine($"mehsulun ededi;{Count}");
            }
        }

    }
}
