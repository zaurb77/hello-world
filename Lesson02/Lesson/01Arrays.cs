using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Lesson
{
  class _01Arrays
  {
    public static void Arrays()
    {
      int[,] mas = {  { 1, 2, 3 }, 
                      { 4, 5, 6 }, 
                      { 7, 8, 9 }, 
                      { 10, 11, 12 } };

      int rows = mas.GetUpperBound(0) + 1;

      // перебор двумерного массива
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < mas.Length/rows; j++)
        {
          Console.Write(mas[i,j] + " ");
        }
        Console.WriteLine();
      }

      //зубчатый массив
      int[][] zmas = new int[3][]; 
      zmas[0] = new int[] {5,4};
      zmas[1] = new int[] { 3, 5, 2 };
      zmas[2] = new int[] { 1 };



      // перебор зубчатого массива
      for (int i = 0; i < zmas.Length; i++)
      {
        for (int j = 0; j < zmas[i].Length; j++)
        {
          Console.Write(zmas[i][j] + " ");
        }
        Console.WriteLine();
      }

      Console.WriteLine("Подсчет суммы чисел главной диагонали");

      int[,] mas2 = {  { 1, 2, 3 },
                      { 4, 5, 6 },
                      { 7, 8, 9 }};

      int sum = 0;
      int row = mas2.GetUpperBound(0) + 1;
      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < mas2.Length / row; j++)
        {
          Console.Write(mas2[i, j] + " ");
          if (i==j)
          {
            sum += mas2[i, j];
          }
        }
        Console.WriteLine();
      }

      Console.WriteLine("Сумма числе главной диагонали: {0}", sum);

    }
  }
}
