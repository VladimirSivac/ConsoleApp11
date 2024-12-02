// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    /// <summary>
    /// Centimeters
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Input("Количество метров: ");
            int c = Input("Количество сантиметров: ");
            Output(Centimeters(m, c));
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        
        static void Output(int result)
        {
            Console.WriteLine($"Всего сантиметров: {result}");
        }
    }
}