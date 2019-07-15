using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.DZ
{
  class DZ4
  {
    /*
    Задача 4
    Создать двумерный массив и найти сумму всех его элементов.
    */

    public static void SumArrayElements()
    {
      int[,] arr = 
      {
        {1, 2, 3, 4, 5},
        {6, 7, 8, 9, 10},
        {3, 11, 2, 19, 21}
      };

      int rowLength = arr.GetLength(0);
      int colLength = arr.GetLength(1);
      int sum = 0;
      for (int i = 0; i < rowLength; i++)
      {
        for (int j = 0; j < colLength; j++)
        {
          sum += arr[i, j];
        }
      }
      Console.WriteLine("Sum of all elements is: {0}", sum);
    }

  }
}
