using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // ONLY put code here to instantiate 1 OBJECT and run a method to start the application

            CounterSampleCalculator c = new Calculator();
            int answer = c.DoFactorial(5);
        }
    }

    class Calculator
    {
        public int DoFactorial(int starterNumber)
        {
            int answer = 0;

            return answer;
        }
    }

}
