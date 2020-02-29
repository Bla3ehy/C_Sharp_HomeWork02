using System;

namespace HomeWork001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段數字");
            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine(inputNumber / -2);
            }
            else
            {
                var ans = (inputNumber / 2) * -1 + inputNumber;
                Console.WriteLine(ans);
            }
        }
    }
}