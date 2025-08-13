using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Laboratory_Exercise_1_Madayag
{
    internal class CalculatorClass
    {
        public delegate T Formula<T>(T num1, T num2);
        public Formula<double> formula;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }

        public delegate double delCal(double num1, double num2);

        private delCal calculateEvent;

        public event delCal CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the delegate! ^^");
            }
            remove
            {
                Console.WriteLine("Removed the delegate! :<");
            }
        }
    }
}
