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

            static public void Main(string[] args)
        {
            int[] a = { 1, 4, 0, 0, 3, 10, 5 };
            int[] b = { 1, 2, 3, 4, 5 };
            int[] c = { 1, 4, 20, 3, 10, 5 };

            SortedSubarray(a, -1);
            SortedSubarray(b, 5);
            SortedSubarray(c, 33);
            
            }

    }
}
