using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Interfaces;

namespace ProjectEuler.Problems
{
    public class Problem001 : IRunEuler
    {
        public void Execute()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
                //if (i % 5 == 0)  /*Overcounts because will hit if statement twice
                //{
                //    sum += i;
                //}
            }

            Console.WriteLine("Total for Multiples of 3 and 5 is: {0}", sum);
        }

    }
}
