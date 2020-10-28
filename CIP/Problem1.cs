using System;
using System.Collections.Generic;
using System.Text;

namespace CIP
{
    class Problem1
    {
        /// <summary>
        /// Given an unsorted array of integers, 
        /// find a subarray which adds to a given number. If there are more than one subarrays with sum as the given number, print any of them
        /// </summary>
        /// <param name="a"></param>
        /// <param name="r"></param>
        static public void SortedSubarray(int[] a, int r)
        {
            int suma = a[0];
            int j = 0;
            bool isPossible = false;
            for(int i =1; i < a.Length; i++)
            {
                if (suma == r)
                {
                    Console.WriteLine("Los indices son: {0} y {1}", j, i-1);
                    isPossible = true;
                    break;
                }
                if (suma < r)
                {
                    suma += a[i];
                }
                else
                {
                    suma -= a[j];
                    j++;
                    i--;
                }
            }
            if(!isPossible)
               Console.WriteLine("-1");
        }

        /// <summary>
        /// 
        /// Write a program to sort an array of 0's,1's and 2's in ascending order.
        /// </summary>
        /// <param name="a"></param>
        static public void SortZerosAndOnes(int[] a)
        {
            foreach (int x in a)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();

            int i=0, j=0, k=a.Length-1;

            for (; k >= 0; k--)
            {
                if (a[k] != 2) 
                    break;
            }

            for (j = 0; j <= k; j++)
            {
                if (a[j] == 2)
                {
                    a[j] = a[k];
                    a[k] = 2;
                    k--;
                    j--;
                }
                else
                {
                    if (a[j] == 0)
                    {
                        a[j] = a[i];
                        a[i] = 0;
                        i++;
                    }
                }
            }

            foreach(int x in a)
            {
                Console.Write(x + "  ");
            }
        }


        //Question 9
        static public void printSpiralArray(int[,] arr)
        {
            int x = arr.GetLength(1);// obtaing length of x
            int y = arr.GetLength(0); //length of y

            int j = 0, i = 0, layer = 1;
            while (layer <= x / 2 && layer <= y / 2)
            {
                while (i < (x - layer))//->
                {
                    Console.Write(arr[j, i] + " ");
                    i++;
                }
                while (j < (y - layer))
                {
                    Console.Write(arr[j, i] + " ");
                    j++;
                }
                while (i > (layer - 1))//<-
                {
                    Console.Write(arr[j, i] + " ");
                    i--;
                }
                while (j > (layer - 1))
                {
                    Console.Write(arr[j, i] + " ");
                    j--;
                }
                j = i = layer;
                layer++;
            }
            layer--;
            if (y % 2 == 1 && x % 2 == 1)
            {
                Console.Write(arr[i, j]);
            }
            if (y % 2 == 0 && x % 2 == 1)
            {
                while (j < y - layer)
                {
                    Console.Write(arr[j, i] + " ");
                    j++;
                }
            }
            if (x % 2 == 0 && y % 2 == 1)
            {
                while (i < x - layer)
                {
                    Console.Write(arr[j, i] + " ");
                    i++;
                }
            }
        }

        //0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2

        //static public void Main(string[] args)
        //{
        //    int[] z = { 0, 1, 2, 2, 2, 1, 1, 0, 0, 1, 1, 2, 0 };

        //    SortZerosAndOnes(z);

        //    //int[] a = { 1, 4, 0, 0, 3, 10, 5 };
        //    //int[] b = { 1, 2, 3, 4, 5 };
        //    //int[] c = { 1, 4, 20, 3, 10, 5 };

        //    //SortedSubarray(a, -1);
        //    //SortedSubarray(b, 5);
        //    //SortedSubarray(c, 33);
            
        //    }

    }
}
