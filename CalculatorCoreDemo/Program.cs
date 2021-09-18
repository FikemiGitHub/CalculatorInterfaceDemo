using CalculatorLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorCoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new CalculatorClass(new CalculatorService()).Calculate();
        }
    }
}
