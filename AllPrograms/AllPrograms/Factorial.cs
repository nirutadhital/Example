using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Factorial
    {
        public Factorial()
        {
            String str;
            Console.WriteLine("Enter the number");
            str = Console.ReadLine();
            int n=int.Parse(str);
            int i;
            int fact = 1;
            for(i = 1; i <= n; i++)
            {
                fact *= i;

            }
            Console.WriteLine(fact);
        }


    }
}
