using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_and_even_plus_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Question 1
             * Control Variable - loop counter 
             * Initial Value - value of the control variable
             * Increment or decrement variable - modifies the control variables value
             * Loop-continuation condition - determines whether looping should continue
             * 
             * Question 2
             * The both execute a statement or a block of statements while the Boolean expression is true. The difference is you use 
             * the for loop when you know how many times the code needs to be looped and the while loop when you are unsure.
             * 
             * Question 3 
             * If you want the do block to be executed at least once. 
             * 
             * 
             */
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is even");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
