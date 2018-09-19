using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._9
{
    class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("2到100之间所有的素数：");
            int n = 0;
            for(int i = 3; i < 100; i += 2)
            {
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        goto outer;
                }
                Console.WriteLine(" " + 1);
                n++;
                if (n < 10)
                    continue;
                Console.WriteLine();
                n = 0;
            outer:;

            }
            Console.WriteLine();
        }
    }
}
