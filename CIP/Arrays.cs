using System;
using System.Collections.Generic;
using System.Text;

namespace CIP
{
    class Arrays
    {
        static public bool IsMatch(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            for(int i = 0; i < s1.Length; i++)
            {
                if (s2[i] == '*')
                {
                    continue;
                }
                if (s2[i] == '#')
                {
                    if (!Char.IsNumber(s1[i]))
                        return false;
                    continue;
                }

                if (s1[i] != s2[i])
                    return false;
            }
            return true;
        }

        static public int FindKth(int[] a, int k)
        {
            int[] sa = MergeSort(a);
            return (sa[k-1]);
        }

        static public int[] MergeSort(int[] array)
        {
            int n = array.Length;

            if (n == 1)
                return array;

            int[] a = new int[n / 2];
            int[] b = new int[(n / 2) + (n % 2)];

            int i = 0, j=0;
            while (i < a.Length)
            {
                a[i] = array[i];
                i++;
            }
            while (i < array.Length)
            {
                b[j]= array[i];
                j++;
                i++;
            }

            return Merge(MergeSort(a), MergeSort(b));
       




        }

        static public int[] Merge(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];

            int i = 0, j = 0, k=0; //i-a, j-b, k-r

            while(i<a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    result[k]=a[i];
                    i++;
                }
                else
                {
                    result[k] = b[j];
                    j++;
                }
                k++;
            }
            if (i == a.Length && j < b.Length)
            {
                while (k < result.Length)
                {
                    result[k] = b[j];
                    k++;
                    j++;
                }
            }
            if (j == b.Length && i < a.Length)
            {
                while (k < result.Length)
                {
                    result[k] = a[i];
                    k++;
                    i++;
                }
            }
  
            return result;

        }


        //static public void Main(string[] args)
        //{
        //    int[] a1 = {3, 2, 5, 7, 6, 0, 8, 4};
        //    int[] b1 = { 0, 1, 6, 10 };

        //    int[] x = MergeSort(a1);

        //    foreach(int c in x)
        //    {
        //        Console.Write(c + " , ");
        //    }


        //    Console.WriteLine("\n"+ FindKth(a1, 3));
           
        //    //Console.WriteLine(IsMatch("ab31z", "ab31z"));
        //    //Console.WriteLine(IsMatch("ab31z", "ab#1"));

        //    //Console.WriteLine(IsMatch("ab31z", "ab*1#"));


        //}
    }
}
