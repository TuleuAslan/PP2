using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathstring = @"C:\Users\пк\Desktop\newfile";
            string pathstring1 = @"C:\Users\пк\Desktop\newfile";
            Directory.CreateDirectory(pathstring);
            string fileName = "MyNewFile.txt";
            pathstring = Path.Combine(pathstring, fileName);
            Console.WriteLine("Path to my new folder: {0}\n", pathstring);
            File.Create(pathstring);
            string newpath = @"C:\Users\пк\Desktop\pathtocopy";
            /* string[] files = Directory.GetFiles(pathstring1);
             foreach(string s in files)
             {
                 File.Copy(s, newpath, true);
             } */
            newpath = Path.Combine(newpath, fileName);
            File.Create(newpath);
            File.Delete(pathstring1);

        }
    }
}
