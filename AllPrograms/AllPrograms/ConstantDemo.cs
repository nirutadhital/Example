using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class ConstantDemo
    {
        public ConstantDemo()
        {

            const float pi = 3.14f;
            float cir = 2 * pi * 5;
            float a = pi * 5 * 5;

            //type conversion
            //int i = 90;
            //long l = i;//Automatic type conversion

            //Expicit/forced type conversion
            //long i = 90;
            //int l =(int) i;

            int ig=Convert.ToInt32("23");
            //this first convert 23 into int and assign to ig

        }
    }
}
