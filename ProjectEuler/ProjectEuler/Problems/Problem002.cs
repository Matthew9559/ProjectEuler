using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Interfaces;

namespace ProjectEuler.Problems
{
    public class Problem002 : IRunEuler
    {       

        public void Execute()
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int sum = 0;
            int evenSum = 0;

            while (secondNumber < 4000000)
            {                
                sum = firstNumber + secondNumber;                
                firstNumber = secondNumber;
                secondNumber = sum;

                if (sum % 2 == 0)
                {
                    evenSum += sum;
                }
            }

            Console.WriteLine("The total for even Fibonacci numbers is: {0}", evenSum);
        }
    }
}
