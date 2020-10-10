using System;
using System.Collections.Generic;

namespace CIP
{
    class Program
    {

        /// <summary>
        /// You are given a list of n-1 integers and these integers are in the range of 1 to n. 
        /// There are no duplicates in list. One of the integers is missing in the list. 
        /// Write an efficient code to find the missing integer.
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        static public int findMissing(List<int> l) // (1,2,5,3) missing=4
        {
            int n = l.Count;

            l.Sort(); //(1,2,3,5)
            int[] myarray = l.ToArray();


            if (myarray[0] != 1)
                return 1;

            for(int i = 1; i < n; i++)
            {
                if (myarray[i] != myarray[i - 1] + 1)
                    return i+1;                
            }

            return n + 1;

        }
      //  1+2+3+4..+n

           // =n(n+1)/2
        static public int find2(List<int> l)
        {
            int n = l.Count;

            int[] arr = l.ToArray();

            int suma = 0;

            for(int i = 0; i < n; i++)
            {
                suma += arr[i];
            }
            int temp= ((n + 1) * ( n+2)) / 2;

            return temp - suma;
        }

        //static void Main(string[] args)
        //{
        //    List<int> a = new List<int>{ 4, 2, 1, 3 };
        //    Console.WriteLine(find2(a));
        //}
    }
}
