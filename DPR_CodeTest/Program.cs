using DPR_CodeTest.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello! Please enter your bank balance to see your interest rate: ");
                var input = Console.ReadLine();

                decimal parsedInput = 0.00m;

                if (decimal.TryParse(input, out parsedInput))
                {
                    var calculator = new InterestCalculator();
                    var interest = calculator.Calculate(parsedInput);
                   
                    Console.WriteLine($"Thank you. Your calculated interest is {string.Format("{0:C}", interest)}");
                }
            }
        }
    }
}
