using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeftRotation();
            Console.WriteLine("\n");
            RightRotation();
            Console.WriteLine("\n");
            SumOfDigits();
            Console.WriteLine("\n");
            SecondMaxMin();
            Console.WriteLine();
        }

        public static void LeftRotation()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array: {0}", string.Join(", ", a));

            int temp;
            for(int j = a.Length; j > 0; j--)
            {
                temp = a[a.Length - 1];
                a[a.Length - 1] = a[j - 1];
                a[j - 1] = temp;
            }

            foreach(int num in a)
            {
                Console.Write(num + " ");
            }
        }


        public static void RightRotation()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array: {0}", string.Join(", ", a));

            int temp;
            for(int j = 0; j < a.Length - 1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }

            foreach(int num in a)
            {
                Console.Write(num + " ");
            }
        }


        public static void SumOfDigits()
        {
            int n = 12345;

            Console.WriteLine(n);

            int sum = 0;

            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine("Sum of Digits");
            Console.WriteLine(sum);
        }


        public static void SecondMaxMin()
        {
            int[] a = new int[] { 2, 5, 3, 7, 4, 8, 6};

            Console.WriteLine("Array: {0}", string.Join(", ", a));

            int max = int.MinValue;
            int secmax = int.MinValue;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    secmax = max;
                    max = a[i];
                }
                else if (a[i] > secmax && a[i] != max)
                {
                    secmax = a[i];
                }
            }

            Console.WriteLine("Second Maximun: " + secmax);

            int min = int.MaxValue;
            int secmin = int.MaxValue;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    secmin = min;
                    min = a[i];
                }
                else if (a[i] < secmin && a[i] != min)
                {
                    secmin = a[i];
                }
            }

            Console.WriteLine("Second Minimum: " + secmin);
        }
    }
}
 