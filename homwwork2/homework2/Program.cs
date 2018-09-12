using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double  n = 0;
            double d = 0;
            Console.Write("Please input a double1:");
            s = Console.ReadLine();
            n = Double.Parse(s);
            Console.Write("Please input a double2: ");
            s = Console.ReadLine();
            d = Double.Parse(s);
            Console.Write("Product of two numbers：" + n * d);
                      }
    }
}
