using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._7
{
    class Program
    {
       public  static void Main(string[] args)
        {
            int[] numbers = { 1, 23, 4, 5, 28, 10 };
            int Lengthofnumbers = numbers.Length;
            int sum=0, max=0, min=0;
            double d=0;
            foreach(int i in numbers)
            {
                sum += i;
                
                

            }
            for (int a = 0; a < Lengthofnumbers-1;a++)
            {
                int b = a + 1;
                    numbers[b] = numbers[a] > numbers[b] ? numbers[a] : numbers[b];
            }
            max = numbers[Lengthofnumbers-1];
            for (int e = 0; e < Lengthofnumbers - 1; e++) 
            {
                int t = e + 1;
                    numbers[t] = numbers[e] <numbers[t] ? numbers[e] : numbers[t];
            }
            min= numbers[Lengthofnumbers - 1];
            d = (double)sum / Lengthofnumbers;
            Console.WriteLine("这个数组的最大值为"+max);
            Console.WriteLine("这个数组的最小值为" + min);
            Console.WriteLine("这个数组的总和为" + sum);
            Console.WriteLine("这个数组的平均值为" + d);





        }
    }
}
