using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool Prime(int a)
        {
            bool cnt = true;
            if (a <= 1)
            {
                return false;
            }
            else
            {
                for(int i = 2; i <= a/2; i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            StreamReader re = new StreamReader(@"C:\Users\пк\Desktop\PP2 C#\Week 2\Task2\input.txt");
            string s = re.ReadToEnd();
            string[] ss = s.Split(' ');
            StreamWriter wr = new StreamWriter(@"C:\Users\пк\Desktop\PP2 C#\Week 2\Task2\output.txt");
            for(int i = 0; i < ss.Length; i++)
            {
                int a = int.Parse(ss[i]);
                if (Prime(a))
                {
                    wr.Write(a + " ");
                }
            }
            wr.Close();
        }
    }
}
