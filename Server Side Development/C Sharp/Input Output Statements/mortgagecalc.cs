//C# Lab 1 mortgage calculator code by Alisher Yuldashev. 
//Programming Diploma - SharePoint Specialization (Innotech College).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab01Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constants (k)
            const int kMonthsInYear = 12;
            const int kTwoDecimalPlaces = 2;
            const double kPercentage = 100.0;
            #endregion

            #region Variables Declaration
            // this is user's input in text format
            string _AmountEntered = String.Empty;
            string _InterestEntered = String.Empty;
            string _MonthsEntered = String.Empty;

            // These variables represent the string values, converted to numeric values
            double _AmountBorrowed = Double.MinValue;
            double _InterestRatePerYear = Double.MinValue;
            double _InterestRatePerMonth = Double.MinValue;
            double _MonthsToPayback = Double.MinValue;
            double _YearsToPayBack = Double.MinValue;
            double _MonthlyPayment = Double.MinValue;
            #endregion

            #region Ask the user for input            
            while (String.IsNullOrWhiteSpace(_AmountEntered) == true) {                
                Console.Write("Please enter the amount you wish to borrow: ");
                _AmountEntered = Console.ReadLine();
            }
         
            while (String.IsNullOrWhiteSpace(_InterestEntered) == true)
            {
                Console.Write("What is the yearly interest rate you have been quoted: ");
                _InterestEntered = Console.ReadLine();
            }
            
            while (String.IsNullOrWhiteSpace(_MonthsEntered) == true)
            {
                Console.Write("What is the number of months you wish to take to pay back the loan: ");
                _MonthsEntered = Console.ReadLine();
            }
            #endregion

            #region Convert the string input into numbers for use in the math equation            
            _AmountBorrowed = Convert.ToDouble(_AmountEntered);
            _InterestRatePerYear = Convert.ToDouble(_InterestEntered) / kPercentage;
            _InterestRatePerMonth = _InterestRatePerYear / kMonthsInYear;
            _MonthsToPayback = Convert.ToDouble(_MonthsEntered);
            _YearsToPayBack = Convert.ToDouble(_MonthsEntered) / kMonthsInYear;
            #endregion

            #region Calculate the monthly payment using the math formula
            // Calculate the  (1 + i)^n   using   Math.Pow()
            double power = Math.Pow(1 + _InterestRatePerMonth, _MonthsToPayback);
            double numerator = (_InterestRatePerYear / kMonthsInYear) * power;
            double denominator = power - 1;
            double fraction = numerator / denominator;
            // Round the answer to 2 decimal places using Math.Round()
            _MonthlyPayment = Math.Round(_AmountBorrowed * fraction,kTwoDecimalPlaces);
            #endregion

            #region Output the result            
            //  See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings for formatting rules:
            Console.WriteLine("\n\n"); 
            Console.WriteLine("For a loan of " + (_AmountBorrowed.ToString("C2")) + " dollars");
            Console.WriteLine("Amortized over " + _MonthsToPayback  + " months (" + _YearsToPayBack + " years)");
            Console.WriteLine("At an annual interest rate of " + _InterestRatePerYear.ToString("P") +" percent");
            Console.WriteLine("\nYou would need to pay " + _MonthlyPayment.ToString("C2")  + " per month");
            #endregion

            Console.Write("\n\nPress return to close the window\n\n");
            Console.ReadLine();

        }
    }
}
