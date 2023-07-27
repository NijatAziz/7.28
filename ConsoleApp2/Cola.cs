using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cola:Product
    {
        public byte Litr;
        public Cola( byte litr, int id, double price, int count):base(id, price, count)
        {
            Litr = litr;
        }
    }
}
