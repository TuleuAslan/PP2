using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void MakeArray(int[] ar,int[] arr)
        {
            for (int i = 0; i < ar.Length; i++) // Pushing elements to the another array with doubled
            {
                arr[2 * i] = arr[2 * i + 1] = ar[i];
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Giving length of array
            string s = Console.ReadLine(); //writing elements of array
            string[] ss = s.Split(' '); //adding elements to string array by space
            int[] arr1 = new int[n]; // creating array with n length
            for (int i = 0; i < ss.Length; i++) // converting each element of string array to integer element
            {
                arr1[i] = int.Parse(ss[i]);
            }
            int[] arr2 = new int[n*2];
            MakeArray(arr1 ,arr2); // Using method MakeArray
            foreach (int q in arr2)
            {
                Console.Write(q + " ");
            }
            Console.ReadKey();
        }
    }
}
