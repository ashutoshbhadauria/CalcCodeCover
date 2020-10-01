using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;

namespace TestingConsoleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(args[1], args[2]);
            double result = calc.Calculate(args[0]);
            Console.WriteLine("Result = " + result.ToString());
        }
    }
}
