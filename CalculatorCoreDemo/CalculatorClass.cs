using CalculatorLibrary.Interfaces;
using CalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCoreDemo
{
    public class CalculatorClass
    {
        private readonly ICalculator _calculator;
        public CalculatorClass(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public void Calculate()
        {
            CalculatorModel calculatorModel = new CalculatorModel();

            DisplayMessage("Please enter a number: ");

            calculatorModel.a = CollectUserNumbers();

            DisplayMessage("Please enter a number: ");

            calculatorModel.b = CollectUserNumbers();

            calculatorModel.output = _calculator.Addition(calculatorModel.a, calculatorModel.b);

            DisplayMessage("Result: ");

            DisplayOutput(calculatorModel.output);

            DisplayMessage("Thank you for calculating with me");
        }
        public static void DisplayMessage(string message)
        {
            Console.Write(message);
        }
        public static int CollectUserNumbers()
        {
            var numberString = Console.ReadLine();

            int number = int.Parse(numberString);

            return number;
        }
        public static void DisplayOutput(int Output)
        {
            Console.WriteLine(Output);   
        }
    }
}
