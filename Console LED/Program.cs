using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串數字 :");
            var input = Console.ReadLine();

            CreateLed(input);
        }

        private static void CreateLed(string input)
        {
            var i = 0;
            string[] Top = new string[input.Length];
            string[] Mid = new string[input.Length];
            string[] Bot = new string[input.Length];

            foreach (var item in input)
            {
                switch (item.ToString())
                {
                    case "0":
                        Top[i] += " _ ";
                        Mid[i] += "| |";
                        Bot[i] += "|_|";
                        break;
                    case "1":
                        Top[i] += "  ";
                        Mid[i] += "  |";
                        Bot[i] += "  |";
                        break;
                    case "2":
                        Top[i] += " _ ";
                        Mid[i] += " _|";
                        Bot[i] += "|_ ";
                        break;
                    case "3":
                        Top[i] += " _ ";
                        Mid[i] += " _|";
                        Bot[i] += " _|";
                        break;
                    case "4":
                        Top[i] += "   ";
                        Mid[i] += "|_|";
                        Bot[i] += "  |";
                        break;
                    case "5":
                        Top[i] += " _ ";
                        Mid[i] += "|_ ";
                        Bot[i] += " _|";
                        break;
                    case "6":
                        Top[i] += " _ ";
                        Mid[i] += "|_ ";
                        Bot[i] += "|_|";
                        break;
                    case "7":
                        Top[i] += " _ ";
                        Mid[i] += "  |";
                        Bot[i] += "  |";
                        break;
                    case "8":
                        Top[i] += " _ ";
                        Mid[i] += "|_|";
                        Bot[i] += "|_|";
                        break;
                    case "9":
                        Top[i] += " _ ";
                        Mid[i] += "|_|";
                        Bot[i] += " _|";
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in Top)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in Mid)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in Bot)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

