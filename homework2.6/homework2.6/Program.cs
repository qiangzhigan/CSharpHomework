using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._6
{
    class Program
    {
       public static void Main(string[] args)
        {
            String s;
            int num;
            Console.WriteLine("Input a number:");
             s = Console.ReadLine();
            num = int.Parse(s);
            if (num <= 1)
                Console.WriteLine("这个数没有素因子");


            if (num > 1 && num <= 3)
            {
                Console.WriteLine("这个数的素因子是" + num);

            }
            else
            { Console.WriteLine("这个数的素数因子有");
                if (num % 2 == 0)
                    Console.WriteLine( " " + 2);
                for (int i = 3; i < num; i += 2)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            goto outer;
                    }
                    if (num % i == 0)
                        Console.WriteLine(" " + i);
                    continue;
                outer:;
                }

                }
        }
    }
}
