using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class MiniMaxSum
    {
        internal void TakeInput()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
            miniMaxSum(arr);
        }

        private void miniMaxSum(int[] arr)
        {
            long minSum = 0, maxSum = 0;
            arr = SortArray(arr);
            
            for (int i = 1; i < arr.Length; i++)
            {
                maxSum += arr[i];
            }

            for (int j = 0; j < arr.Length - 1; j++)
            {
                minSum += arr[j];
            }

            Console.WriteLine(minSum + " " + maxSum);
            Console.ReadLine();
        }

        private int[] SortArray(int[] arr)
        {
            List<int> arrElemnts = arr.ToList();
            arrElemnts.Sort();
            return arrElemnts.ToArray();
        }
    }
}
