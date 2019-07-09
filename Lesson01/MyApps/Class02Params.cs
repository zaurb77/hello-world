using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.MyApps
{
  class Class02Params
  {
    public static void ParamsTest()
    {
      Params(5, 3, 9);
      Console.ReadKey();
    }

    static void Params(params int[] a)
    {
      int sum = 0;
      for (int i = 0; i < a.Length; i++)
      {
        sum += a[i];
      }
      Console.WriteLine(sum);
    }
  }
}