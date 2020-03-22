using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //this is the main function where the algorithim will read the array and sort it in order
        static void Main(string[] args)
        {
            int[] a = { 20, 60, 50, 40, 50, 1, 100, 101 }; //this is the array of numbers

            Console.WriteLine("Original Array: ");

            //this for loop will print out the original array
            foreach (int X in a)
            {
                Console.Write(X + ", ");
            }
            //this sorting algorithim is known as a 'Bubble Sort'.
            //it works by comparing the element in the first index with the one adjacent.
            //if the number is greater, (or smaller), the numbers are swapped, depending on whether it is an ascending array or descending.

            int t;

            // The algorithim will travel through the array starting from 0.
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // The sorting algorithim will traverse through the array. 
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //the if statement will check and see if the element adjacent to the next is smaller.
                    if (arr[i] < arr[j])
                    {
                        t = arr[i]; //if so, it will be stored in a temporary variable and their indexes will swap over.
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }

            //finally the sorted array is printed out
            Console.WriteLine("\n" + "Sorted array: ");
            foreach (int aa in a)
            {
                Console.Write(aa + ", ");
                //Console.Write("\n");
            }

        }
    }
}
