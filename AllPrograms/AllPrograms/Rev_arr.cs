using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Rev_arr
    {
        public Rev_arr()
        {
            String str;
            Console.WriteLine("Enter the size of the array:");
            str = Console.ReadLine();
            int n=int.Parse(str);
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements:");
            int i;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse order:");
            for(i=n-1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
           

        }
    }
}
