using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Task11()
        {
            int[] arr = new int[] { 5, 4, 6, 65, 62, 25, 75, 45, 87, 58 };

            int sum = 0;
            
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Sum of elements of array is: " + sum);
        }

        static void Task12()
        {
            int[] arr = new int[] { 5, 4, 6, 2, 8};

            int result = 1;

            foreach (int num in arr)
            {
                result *= num;
            }
            Console.WriteLine("Multiplication of elements of array is: " + result);
        }

        static void Task13()
        {
            int[] arr = new int[] { 25, 244, 96, 365, 12, 85, 3, 14 };

            int minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine("Min value of array is: " + minValue);
        }

        static void Task14()
        {
            int[] arr = new int[] { 25, 244, 96, 365, 12, 85, 3, 14 };

            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine("Max value of array is: " + maxValue);
        }

        static void Task15()
        {
            int[] arr = new int[] { 25, 69, 54, 2, 88, 12 };

            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            int average = sum / arr.Length;
            Console.WriteLine("Average of elements of array is: " + average);
        }

        static void Task16()
        {
            int[] arr = new int[] { 54, 23, 556, 48, 12, 7 };

            int minValue = arr[0];
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }

            Console.WriteLine("Invert min and max value of array:");
            Console.Write(minValue + " ");
            Console.WriteLine(maxValue);
            Console.WriteLine();

            int tmp = minValue;
            minValue = maxValue;
            maxValue = tmp;

            Console.Write(minValue + " ");
            Console.WriteLine(maxValue);

        }

        static void Task17()
        {
            Console.Write("Enter length of first array: ");
            int length1 = int.Parse(Console.ReadLine());

            Console.Write("Enter length of second array: ");
            int length2 = int.Parse(Console.ReadLine());

            int[] arr1 = new int[length1];
            int[] arr2 = new int[length2];

            Console.WriteLine("Enter elements of first array: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of second array: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine("Element is equal");
                    }
                    else
                    {
                        Console.WriteLine("Element is NOT equal");
                    }
                }               
            }           
        }

        static void Task18()
        {
            int[] arr = new int[] { 5, 26, 11, 87, 26 };

            Console.WriteLine("Doubling of all elements of array");
            Console.WriteLine();
            Console.Write("Before: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.Write("After: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();          
        }

        static void Main(string[] args)
        {
            Task11();
            Console.WriteLine("---");
            Task12();
            Console.WriteLine("---");
            Task13();
            Console.WriteLine("---");
            Task14();
            Console.WriteLine("---");
            Task15();
            Console.WriteLine("---");
            Task16();
            Console.WriteLine("---");
            Task17();
            Console.WriteLine("---");
            Task18();
            Console.WriteLine("---");

        }
    }
}
