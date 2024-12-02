using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a = ");
            int b = Input("b = ");
            int z = Min(2 * a, b + a) + Min(2 * a - b, b);
            Output(z);
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Min(int x, int y)
        {
            return (x < y) ? x : y;
        }
        
        static void Output(int result)
        {
            Console.WriteLine($"z = {result}");
        }
    }
}