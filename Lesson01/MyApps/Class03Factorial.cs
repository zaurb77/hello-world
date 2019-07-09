using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.MyApps
{
  class Class03Factorial
  {
    public static void MyFactorial()
    {
      Console.WriteLine(Factorial(5));
    }

    static int Factorial(int n)
    {
      if (n > 0)
      {
        return n * Factorial(n - 1);
      }
      else
      {
        return 1;
      }
    }
  }
}
