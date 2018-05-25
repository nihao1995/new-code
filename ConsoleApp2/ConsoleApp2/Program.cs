using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] data = calc(nums);
            foreach(int x in data)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Hello World!");
            Console.WriteLine()
            Console.ReadKey();
        }
        public static int[] calc(int[] nums)
        {
            int[] data = new int[2];
            data[0] = nums.Length;
            data[1] = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                data[1] += nums[i];
            }
            return data;
        }
    }
}
