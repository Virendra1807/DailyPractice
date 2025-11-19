using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    internal class SortArray
    {

        public static void SortArrayAsc(int[] arr)
        {
            //int[] asc = arr;

            for(int i =0; i<arr.Length-1; i++)
            {
                for (int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i]; 
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            arr.ToList<int>().ForEach(n => Console.WriteLine(n));

        }
    }
}
