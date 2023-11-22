using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Fibo_print_func
    {
        public int Fibonacci(int n)
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
            return a;
        }

        public Fibo_print_func()
        {
            Console.WriteLine("Enter the number of tems you want:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci series are:");
            for(int i=0; i<n; i++)
            {
                int result = Fibonacci(i);
                Console.WriteLine(result + " ");
            }
        }
    }
}
