using System;
using Calc.Lib;
using Console = Colorful.Console;
using System.Drawing;

namespace Calc.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            var calculator = new Calculator();
            var result = calculator.Add(num1, num2);
            Console.WriteLine("Result: " + result);
        }
    }
}