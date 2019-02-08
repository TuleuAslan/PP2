using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static string Space(int a)
        {
            string s = "    ";
            string q = "";
            for(int i = 0; i < a; i++)
            {
                q += s;
            }
            return q;
        }

        static void Splitting(DirectoryInfo dir,int a)
        {
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dires = dir.GetDirectories();
            foreach(FileInfo file in files)
            {
                Console.Write(Space(a));
                Console.WriteLine(file.Name);
            }
            foreach(DirectoryInfo dire in dires)
            {
                Console.Write(Space(a));
                Console.WriteLine(dire.Name);
                Splitting(dire, a + 1);
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\пк\Desktop\IctHw");
            Splitting(dir, 0);
            Console.ReadKey();
        }
    }
}
