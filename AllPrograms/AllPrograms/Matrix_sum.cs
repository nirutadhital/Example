using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    internal class Matrix_sum
    {
        public Matrix_sum()
        {
            string str1, str2;
            //user input for matrix A
            Console.WriteLine("Enter the row of the matrix A:");
            str1 = Console.ReadLine();
            int r1 = int.Parse(str1);
            Console.WriteLine("Enter the column of the matrix A:");
            str1 = Console.ReadLine();
            int c1 = int.Parse(str1);
            int[,] a = new int[r1,c1];
            Console.WriteLine("Enter the elements of matrix A:");
            int i,j;
            for (i = 0; i < r1; i++)
            {
                for(j = 0; j < c1; j++)
                {
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //user input for matrix B
            Console.WriteLine("Enter the row of the matrix B:");
            str2 = Console.ReadLine();
            int r2 = int.Parse(str2);
            Console.WriteLine("Enter the column of the matrix B:");
            str2 = Console.ReadLine();
            int c2 = int.Parse(str2);
            int[,] b = new int[r2, c2];
            Console.WriteLine("Enter the elements of matrix B:");
            
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //displaying result
            // Check if matrix dimensions are compatible for addition
            if (r1 == r2 && c1 == c2)
            {
                int[,] c = new int[r1, c1];

                Console.WriteLine("The Resultant matrix C is:");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Matrix dimensions are not compatible for addition.");
            }

        }
    }
}
