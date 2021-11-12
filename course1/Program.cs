using System;

namespace course1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string str = "x i a o m i n g";
            string[] str1 =str.Split(" ");
           // Console.WriteLine(str1);
            string test = String.Join(",", str1);
            Console.WriteLine(test);
            Console.ReadLine();
        }
        
    }
}
