using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Sorting
{
  class MakeArray
  {
    public static int AskForArrayGenerationMethod()
    {
      Console.Write("Select array generation method (1-params; 2-random)");
      int arrayGenerationMethod = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

      return arrayGenerationMethod;
    }

    public static int[] StartArrayGenerationByMethod(int a)
    {
      int[] arr = new int[] { };
      if (a == 1)
      {
        arr = GetUserParams();
      }
      else if (a == 2)
      {
        arr = MakeRandomArray();
      }
      return arr;
    }
    private static int[] MakeRandomArray()
    {
      Console.Write("Input a minimum value: ");
      var minValue
        = int.Parse(Console.ReadLine());
      Console.Write("Input a maximum value: ");
      var maxValue = int.Parse(Console.ReadLine());
      Console.Write("Input number of elements: ");
      var values = int.Parse(Console.ReadLine());
      int[] p = new int[values];
      Random rand = new Random();

      for (int i = 0; i < values; i++)
      {
        p[i] = rand.Next(minValue, maxValue);
      }

      Console.WriteLine("Random array generated");
      foreach (var el in p)
      {
        Console.WriteLine(el + " ");
      }

      return p;
    }
    private static int[] GetUserParams()
    {
      Console.WriteLine("Enter your numbers ('z' to finish):");
      string s = null;
      string l = null;
      l = Console.ReadLine();
      while (l != "z")
      {
        s += l + ",";
        l = Console.ReadLine();
      }
      int[] arr = Array.ConvertAll(ConvertStringToIntArray(s), int.Parse);
      return arr;
    }
    private static string[] ConvertStringToIntArray(string s)
    {
      s = s.TrimEnd(',');
      string[] str = s.Split(',');
      foreach (var n in str)
      {
        Console.Write(n + " ");
      }
      return str;
    }
  }
}
