using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listInput = Console.ReadLine().Split(' ').ToList();
            double result = 0;
            var a = double.Parse(listInput[0]);
            var b = double.Parse(listInput[2]);

            switch (listInput[1])
            { 
                    case "+":
                    result = a + b;
                        break;
                    case "-":
                    result = a - b;
                    break;
                    case "*":
                    result = a * b;
                    break;
                    case "/":
                    result = a / b;
                    break;
                    default:
                        break;
            }
            Console.WriteLine(result);
        }
    }
}
