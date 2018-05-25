using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] data2 = { 'a', 'b', 'c', '2' };
            string dddd = new string(data2);
            Console.WriteLine(dddd);

            string[] name = { "张三", "李四", "王五", "李六" };
            String data = string.Join("|", name);
            Console.WriteLine(data);
            string s = "a b c    def___ + = sd ,,";
            char[] chs = { ' ', '_', '+', '=', ',' };
            string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i<str.Length; i++)
                Console.Write(str[i]+" ");
            string s1 = "abcd";
            char[] s2 = s1.ToCharArray();
            Array.Reverse(s2);
            s1 = new string(s2);
            Console.WriteLine(s1);

            //string input = Console.ReadLine();
            //char[] chs2 = { ' ' };
            //string[] str1 = input.Split(chs2, StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(str1);
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    Console.Write(str1[i] + " ");
            //}
            string data1 = string.Concat("w", "ww", "rrrr");
            Console.WriteLine(data1);

            Console.ReadKey();

        }
    }
}
