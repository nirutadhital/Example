using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Temp_convert
    {
        public Temp_convert()
        {
            Console.WriteLine("Enter the value in centigrade:");
            double c=Convert.ToDouble(Console.ReadLine());
            double f =(double) 9 / 5 * c + 32;
            Console.WriteLine("the resilt is:" + f);
        }
       
    }
}
