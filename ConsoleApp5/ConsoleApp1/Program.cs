using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Administrator\Desktop\书名.txt";
            int num = 0;
            string date = File.ReadAllText(path, Encoding.Default);
            char[] d = { ' ', '\n', '\r' };
            string[] new_data = new string[10];
            string[] s = date.Split(d, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i<s.Length; i+=2)
            {
                new_data[i-num] = s[i] + "|" + s[i+ 1];
                Console.WriteLine(new_data[i - num]);
                num++;  
            }
            
            Console.ReadLine();

        }
    }
}
