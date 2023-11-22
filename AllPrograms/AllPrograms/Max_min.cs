using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Max_min
    {
        public Max_min()
        {
            String str;
            Console.WriteLine("Enter the size of the array:");
            str = Console.ReadLine();
            int n=int.Parse(str);
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements:");
            int i;
            for(i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = a[0];
            int max = a[0];
            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max= a[i];
                }
                if (a[i] < min)
                {
                    min= a[i];
                }
            }
            Console.WriteLine($"The min element is {min} and maximum element is {max}");

        }
    }
}
