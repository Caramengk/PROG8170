using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                if (choice == 2)
                {
                    break;
                }

                Console.Write("Enter screen width in pixels: ");
                int width;

                while (!int.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }

                Console.Write("Enter screen height in pixels: ");
                int height;
                while (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }

                Console.Write("Enter diagonal size in inches: ");
                int diagonal;
                while (!int.TryParse(Console.ReadLine(), out diagonal))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }

                string answer = PixelCalc.CalcPixel(width, height, diagonal);
                Console.WriteLine(answer);
            }
        }
    }
}
