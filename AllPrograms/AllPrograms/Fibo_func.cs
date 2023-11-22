using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Fibo_func
    {
        public bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int i;
            for (i = 1; i <= n; i++)
            {
                c = a + b;
                a = b; b = c;
            }
            return a == n;

        }
        public Fibo_func()
        { 
            int n=int.Parse(Console.ReadLine());
            if(IsFibonacci(n))
            {
                Console.WriteLine("The number is Fibonacci");
            }
            else
            {
                Console.WriteLine("The number is not fibonacci");
            }
        }
    }
}
