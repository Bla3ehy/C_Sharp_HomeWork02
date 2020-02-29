using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的數字 :");
            string[] numbers = Console.ReadLine().Split(',');

            var num =
                from n in numbers
                group n by int.Parse(n) % 2 == 0;

            foreach (var n in num)
            {
                if (n.Key)
                {
                    Console.Write("偶數 :");
                }
                else
                {
                    Console.Write("奇數 :");
                }

                foreach (var period in n)
                {
                    string all = period + ",";
                    string ans = all.Substring(0, all.Length - 1);
                    Console.WriteLine(ans);
                }
            }


            Console.ReadLine();



        }
    }
}
