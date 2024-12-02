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
            int a1 = Input("a1 = ");
            int a2 = Input("a2 = ");
            int b1 = Input("b1 = ");
            int b2 = Input("b2 = ");
            int c1 = Input("c1 = ");
            int c2 = Input("c2 = ");
            double y = Function(a1, a2) + Function(b1, b2) + Function(c1, c2);
            Output(y);
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static double Function(int x, int y)
        {
            return (x + Math.Sqrt(y)) / (y + Math.Sqrt(x));
        }
        
        static void Output(double result)
        {
            Console.WriteLine($"y = {result}");
        }
    }
}