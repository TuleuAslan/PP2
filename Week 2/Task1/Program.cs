using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
namespace Task1
{
    class Program
    {
        public static bool Poly(string ss)
        {
            bool cnt = true;
            for(int i = 0; i < ss.Length / 2; i++)
            {
                if (ss[i] != ss[ss.Length - 1 - i])
                {
                    return false;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string file=File.ReadAllText(@"C:\Users\пк\Desktop\PP2 C#\Week 2\Task1\text.txt");

            if (Poly(file))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
