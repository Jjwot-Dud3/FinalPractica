using System;
using DivisionLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DivisionLib.Division.DivisionMethod(ref number1, ref number2));
        }
    }
}
