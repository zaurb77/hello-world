using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.MyApps
{
  class Class01RefOut
  {
    public static void RefOut()
    {
      double a = 5.5;
      double b = 3.5;

      double p;
      double s;

      Result(a, b, out p, out s);

      Console.WriteLine("p={0}", p);
      Console.WriteLine("s={0}", s);
    }

    static void Result(double a, double b, out double s, out double p)
    {
      p = 2 * (a + b);
      s = a * b;
    }
  }
}
