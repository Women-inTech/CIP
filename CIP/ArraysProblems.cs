using System;
using System.Collections.Generic;
using System.Text;

namespace CIP
{
    class ArraysProblems
    {
        /// <summary>
        /// Write a program to print all the LEADERS in the array. An element is leader if it is greater than all the elements to 
        /// its right side. And the rightmost element is always a leader. For example int the array {16, 17, 4, 3, 5, 2}, 
        /// leaders are 17, 5 and 2.
        /// </summary>
        /// <param name="a"></param>
        static public void findAllLeaders(int[] a)
        {
            if (a == null)
                return;
            
            int leader = a[a.Length-1];
            Console.Write("Leaders: {0} ", leader);
            if (a.Length == 1)
                return;

            for (int j=a.Length-2; j>=0;j--)
            {
                if (a[j] > leader)
                {
                    leader = a[j];
                    Console.Write(leader + "  ");
                }
            }

        }

        static public void Main(string[] args){
            int[] numbers = new int[3];

            findAllLeaders(numbers);
        }

    }
}
