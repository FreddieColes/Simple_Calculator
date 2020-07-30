using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fred's calculator! \nType your first number, then your second number, then an operation.");
            Start:
            try
            {                
                InputConverter inputConverter = new InputConverter();

                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                //In real world we would want to log this message
                Console.WriteLine(ex.Message);
                goto Start;
            }
            goto Start;
        }
    }
}
