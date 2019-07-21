using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using Lesson02.Sorting.Algorithms;

namespace Lesson02.Sorting
{
  class SelectSortingMethod
  {
    public static int Method()
    {
      List<string> methodsList = new List<string>();
      methodsList = PopulateMethodsList();
      PrintMethodsList(methodsList);

      int selectedMethod = new int();
      selectedMethod=AskUser();
      Console.Clear();
      PrintUserSelectedMethod(methodsList, selectedMethod);
      return selectedMethod;
    }

    private static void PrintUserSelectedMethod(List<string> methodsList, int userSelectedIndex)
    {
      if (userSelectedIndex <0 && userSelectedIndex>37) throw new ArgumentOutOfRangeException(nameof(userSelectedIndex));

      Console.WriteLine($"Selected Sort method is: {methodsList[userSelectedIndex]}");
    }

    private static void PrintMethodsList(List<string> methods)
    {
      foreach (var l in methods)
      {
        //Console.Write(methods.IndexOf(l).ToString() + " ");
        Console.WriteLine(l);
      }
    }

    private static List<string> PopulateMethodsList()
    {
      List<string> methods = new List<string>();
      using (var m = new StreamReader(@"Sorting\SortingMethods.txt"))
      {
        string line = null;
        while ((line = m.ReadLine()) != null)
        {
          methods.Add(line);
        }
      }
      return methods;
    }

    private static int AskUser()
    {
      Console.Write("Select sorting method: ");
      int methodIndex = int.MinValue;
      methodIndex = int.Parse(Console.ReadLine());
      return methodIndex;
    }

    public static void SortBySelectedMethod(int sortingAlgorithm, int[] arrayToSort, string displaySteps)
    {
      switch (sortingAlgorithm)
      {
        case 0:
          Selection.Sort(arrayToSort, displaySteps);
          break;
        case 1:
          Bubble.Sort(arrayToSort, displaySteps);
          break;
        default:
          Console.WriteLine("Invalid algorithm");
          break;
      }
    }
  }
}
