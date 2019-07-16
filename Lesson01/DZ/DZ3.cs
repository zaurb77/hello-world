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
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;

      Console.Write("Введите первое число: ");
      num1= int.Parse(Console.ReadLine());
      

      Console.Write("Введите второе число: ");
      num2 = int.Parse(Console.ReadLine());

      Console.Write("Введите третье число: ");
      num3 = int.Parse(Console.ReadLine());

      Console.Write("Введите четвертое число: ");
      num4 = int.Parse(Console.ReadLine());

      Console.Write("Введите пятое число: ");
      num5 = int.Parse(Console.ReadLine());

      int[] myArray = {num1, num2, num3, num4, num5};
      FindMaxAndMin(ref myArray);
    }

    static void FindMaxAndMin(ref int[] arr)
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
