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
            int c = Input("c = ");;
            double y = Function(a) + Function(b) + Function(c);
            Output(y);
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static double Function(int x)
        {
            return (Math.Sqrt(x) + x) / 3;
        }
        
        static void Output(double result)
        {
            Console.WriteLine($"y = {result}");
        }
    }
}