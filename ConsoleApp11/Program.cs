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
            int r = Input("Количество рублей: ");
            int k = Input("Количество копеек: ");
            Output(Kop(r, k));
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        
        static void Output(int result)
        {
            Console.WriteLine($"Всего копеек: {result}");
        }
    }
}