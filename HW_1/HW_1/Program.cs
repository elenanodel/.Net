using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void MinValue (int a, int b, int c)
        {
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine("Min Value is: {0}", min);
        }

        static void MaxValue (int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine("Max Value is: {0}", a);
            }
            else
            {
                Console.WriteLine("Max Value is: {0}", b);
            }
        }

        static void Main(string[] args)
        {
            MinValue(5, 3, 8);
            MaxValue(655, 485);

            Console.ReadKey();
        }
    }
}
