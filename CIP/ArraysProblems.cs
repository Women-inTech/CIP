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

        static long repeatedString(string s, long n)
        {
            Console.WriteLine("s.lenght: "+s.Length+"   "+"n: " + n);

            if (s.Length >= n)
            {//only count the a
                return countA(s.Substring(0, (int)n));
            }
            long numAonS = countA(s), sum = 0;
            if (numAonS == 0)
                return 0;

            if (s.Length == 1)
                return n*numAonS;

            Console.WriteLine("----->"+numAonS);
            long diff = n - s.Length;
            Console.WriteLine("Diff:   " + diff);
            sum = numAonS + ((diff / s.Length) * numAonS) + countA(s.Substring(0, (int)(diff % s.Length)));
            return sum;
        }

        static private long countA(string s)
        {
            long numAs = 0;
            foreach (char c in s)
            {
                if (c == 'a')
                    numAs++;
            }
            return numAs;
        }

        static int birthday(List<int> s, int d, int m)
        {
            int[] chocolateBar = s.ToArray();
            if(chocolateBar.Length==1 && m == 1)
            {
                if(chocolateBar[0] == d)
                    return 1;
                return -1;
            }
            int total = 0, result=0;
            int length_tmp = 1;
            for(int i = 0; i < chocolateBar.Length-1; i++)
            {
                total = chocolateBar[i];
                length_tmp = 1;
                for(int j=i+1;j <=s.Count-1; j++)
                {
                    total += chocolateBar[j];
                    length_tmp++;
                    if (length_tmp >= m)
                    {
                        if (total == d)
                            result++;
                        break;
                    }
                }

            }
            return result;
        }

        static int workbook(int n, int k, int[] arr)
        {
            int numProblem = 1;
            int spetialProblems = 0;
            int temp, x = 0, page = 1;
            for(int i = 0; i < n; i++)
            {
                temp = arr[i] / k;

                for (x = 1; x <= temp; x++) { //per page
                    numProblem = ((x - 1) * k) + 1; //first problem on page
                    if (page >= numProblem && page <= numProblem + k - 1)
                    {
                        spetialProblems++;

                    }
                    page++;
                }
                if(arr[i]%k > 0)
                {
                    numProblem = (temp * k) + 1;
                    if (page >= numProblem && page <= numProblem + (arr[i] % k - 1))
                        spetialProblems++;
                    page++;
                }
                
            }
            return spetialProblems;
        }


        //static public void Main(string[] args){
        //    int[] numbers = { 4, 2, 6, 1, 10 };

        //    Console.WriteLine(workbook(5,3,numbers)); //4
        
        //}


    }
}
