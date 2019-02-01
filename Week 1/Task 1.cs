using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Program
    {
        static bool Prime(int n) //boolean function which checks is it prime or no
        {
            bool b = true;
            if (n <= 1)
            {
                b = false;
                return b;
            }
            for(int i=2;i<n;i++)
            {
                if(n % i == 0)
                {
                    b = false;
                    return b;
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Converting String to Integer
            int[] ar = new int[n];             //Creating Array with n Length
            string s = Console.ReadLine();    // Writing elements of array
            string[] ss = s.Split(' ');     //adding elements to array of type string 
            for(int i=0;i<ss.Length;++i)    //converting string elements to integer and putting them to integer array
            {
                ar[i] = int.Parse(ss[i]);
            }
            List<int> b = new List<int>(); // creating something like vector
            foreach(int q in ar) // checking each element to prime
            {
                if(Prime(q))
                {
                    b.Add(q);
                }
            }
            Console.WriteLine(b.ToArray().Length); // Showing lenght of prime numbers
            for(int i=0;i< b.ToArray().Length;++i) //showing prime numbers by space
            {
                Console.Write(b[i]+" ");
            }
            Console.WriteLine();
        }
    }
}