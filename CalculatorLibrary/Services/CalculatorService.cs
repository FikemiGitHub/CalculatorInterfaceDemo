using CalculatorLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Services
{
    public class CalculatorService : ICalculator
    {
        public int Addition(int a, int b)
        {
            int output;

            output = a + b;

            return output;
        }
    }
}
