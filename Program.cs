using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] array = new string[6];

            //array[0] = "Tesla";
            //array[1] = "Corvette";
            //array[2] = "Ford";
            /// Method 1 of printing components of an Array
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);


            /// Method 2 
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            /// Method 3
            //foreach (string car in array)
            //{
            //    Console.WriteLine(car);
            //}


            //int[] num = new int[10];
            //int a = 2, b = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    num[i] = 1;
            //    Console.WriteLine(num[i]);

            //}




            int[] array1 = new int[50];
            int[] array2 = new int[50];
            int[] array3 = new int[50];

            //Console.WriteLine("Enter First Array Numbers: ");
            for (int i = 0; i < array1.Length; i++)
            {
               // Console.Write("Enter Element {0}", i);
                array1[i] = i;
            }

            int j = 0, k = 0;

            for (int i = 1; i < array2.Length/2; i++)
            {
                if ((array1[i] % 2) == 0)
                {
                    array2[j] = array1[i];
                    j++;
                }
                else
                {
                    array3[k] = array1[i];
                    k++;
                }
            }
            Console.WriteLine("Even Numbers");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("{0}", array2[i]);
            }

            Console.WriteLine("Odd numbers");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("{0}", array3[i]);
            }

            Console.ReadLine();
        }
    }
}
