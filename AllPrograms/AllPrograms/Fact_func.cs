using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Fact_func
    {
        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        } 
        public Fact_func()
        {
            Console.WriteLine("Enter any number");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("the factorial is:" + Factorial(n));
        }
    }
}
