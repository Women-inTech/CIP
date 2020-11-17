using System;
using System.Collections.Generic;
using System.Text;

namespace CIP
{
    class Matrix
    {
        static public int[,] Rotate90(int[,] matrix) 
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            Console.WriteLine(m + " x " + n); // m columns n rows    

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }

            int[,] result = new int[m, n];// create a new matrix n columns , m rows
            int x;

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    x = matrix[i, j];
                    result[j, n - i - 1] = x;


                }
            }

            Console.WriteLine("Result: Matrix " + n+" x " + m);


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }

            return result;

        }

        static public void Main(string[] args)
        {
            int[,] m = new int[4, 3];
            int values = 1;
            for(int i=0; i < 4; i++)
            {
                for(int j =0; j<3; j++)
                {
                    m[i, j] = values;
                    values++;
                }
            }

            Rotate90(m);
        }
   

    }
}
