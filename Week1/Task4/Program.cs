using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //Writing number of Star triangle
            for (int i = 1; i <= a; i++) // Creating Star Triangle
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }

        }
    }
}
