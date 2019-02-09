using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NewTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\Users\пк\Desktop\PP2 C#\Week 2\NewTask4\first.txt";
            StreamWriter wr = new StreamWriter(a);
            wr.Write("Kobiii");
            wr.Close();
            string b = @"C:\Users\пк\Desktop\PP2 C#\Week 2\NewTask4\second.txt";
            File.Copy(a, b, true);
            File.Delete(a);
        }
    }
}
