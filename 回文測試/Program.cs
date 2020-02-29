using System;

namespace HomeWork002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段數字或字串 :");
            string inPut = Console.ReadLine();
            MyClass good = new MyClass();
            if (good.StringTest(inPut) == true)
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是回文");
            }
        }
    }
}