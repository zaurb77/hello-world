using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Sorting.Algorithms
{
  class Bubble
  {
    public static void Sort(int[] arr, string steps)
    {
      int n = arr.Length;
      for (int i = 0; i < n - 1; i++)
      {
        for (int j = 0; j < n - i - 1; j++)
          if (arr[j] > arr[j + 1])
          {
            // swap temp and arr[i] 
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;

          }
        if (steps == "y")
          Lesson02.Sorting.Sort.PrintArray(arr);
      } 
      
    }
  }
}
