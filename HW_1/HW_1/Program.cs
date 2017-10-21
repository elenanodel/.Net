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
                if (a < b && a < c)
                {
                    Console.WriteLine("Min Value is: {0}", a);
                }
                if (b < a && b < c)
                {
                    Console.WriteLine("Min Value is: {0}", b);
                }
                if (c < a && c < b)
                {
                    Console.WriteLine("Min Value is: {0}", c);
                }
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
