using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lesson01.MyApps;

namespace Lesson01.DZ
{
  class DZ3
  {
    /* Задача 3
    Пользователь вводит n чисел.При помощи params и ref вывести наибольшее и наименьшее число.
    */

    public static void InputNumbers()
    {
      int num= int.Parse(Console.ReadLine());
      FindMaxAndMin(num);
      

      //FindMaxAndMin(int.Parse(num));
    }

    static void FindMaxAndMin(params int[] arr)
    {

      int max=arr[0];
      int min=arr[0];

      foreach (var t in arr)
      {
        if (max < t)
        {
          max = t;
        }

        if (t<min)
        {
          min = t;
        }
      }

      Console.WriteLine("Max number is: {0}", max);
      Console.WriteLine("Min number is: {0}", min);
    }

  }
}
