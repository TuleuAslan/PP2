using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Giving length of array
            string s = Console.ReadLine(); //writing elements of array
            string[] ss = s.Split(' '); //adding elements to string array by space
            int[] arr1 = new int[n]; // creating array with n length
            for(int i = 0; i < ss.Length; i++) // converting each element of string array to integer element
            {
                arr1[i] = int.Parse(ss[i]);
            }
            foreach(int q in arr1) // showing each element twice
            {
                for(int i = 0; i < 2; i++)
                {
                    Console.Write(q+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
