using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Problems.ArraysDoubleSingle
{
    public class ArrayProblems
    {
        public static List<int> reverseArray(List<int> a)
        {
            int start=0,end=a.Count;
            while (start < end) {
                int temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                start++;
                end--;            
            }
            return a;
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            int sum = int.MinValue;
            for (int i = 0; i < arr.Count-2; i++) { 
            for (int j = 0; j < arr[i].Count-2; j++)
                {
                    int arraysum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                             + arr[i + 1][j + 1]
                                   + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    sum = Math.Max(sum, arraysum);
                }
            }
            return sum;
        }
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            List<int> array = new List<int>();
            int j = d;
            while (j < arr.Count)
            {
                array.Add(arr[j]);
                j++;
            }
            j = 0;
            while (j < d)
            {
                array.Add(arr[j]);
                j++;
            }
            return array;

        }
        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
    {
            List<int> lisitem = new List<int>();
            foreach (var items in queries){
                int i = 0;
            foreach(var list in stringList){
                    if (items.Equals(list))
                    {
                        i++;
                    }
            }
            lisitem.Add(i);
                return lisitem;
        }
            return lisitem;

    }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftdiagnol=0, rightdiagnol= 0;
            for (int i = 0; i < arr.Count; i++) {
                leftdiagnol += arr[i][i];
                rightdiagnol += arr[i][arr.Count - 1 - i];
            }
            return Math.Abs(leftdiagnol-rightdiagnol);

        }
        public static void plusMinus(List<int> arr)
        {
            int[] arar=new int[3];
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    arar[0]+= 1;
                }
                else if (item < 0)
                {
                    arar[1] += 1;
                }
                else if(item==0)
                {
                    arar[2] += 1;
                }
            }

            foreach (var item in arar)
            {
                float ratios=arr.Count;
                Console.WriteLine((item/ratios).ToString("F6"));
            }

        }
        public static void countApplesAndOranges
(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applecount = 0,orangescount=0;
            for (int item= 0;item<apples.Count; item++) { 
            apples[item]+=a;
                if (apples[item]>=s && apples[item] <= t)
                {
                    applecount++;
                }

            }
            for (int item = 0; item < oranges.Count; item++)
            {
                oranges[item] += b;
                if (oranges[item] >= s && oranges[item] <= t)
                {
                    orangescount++;
                }

            }
            Console.WriteLine(applecount);
            Console.WriteLine(orangescount);

        }


    }
}
