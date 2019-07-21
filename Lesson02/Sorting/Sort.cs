using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson02.Sorting;
using Lesson02.Sorting.Algorithms;

namespace Lesson02.Sorting
{
  class Sort
  {
    public static void SortArray()
    {
      Console.WriteLine("Welcome to array sorting app.");

      var arraySortingMethod=SelectSortingMethod.Method();
      var arrayGenerationMethod = MakeArray.AskForArrayGenerationMethod();
      var myArray = MakeArray.StartArrayGenerationByMethod(arrayGenerationMethod);

      PrintArray(myArray);
      var displaySortingSteps=AskForSortingStepsDisplay();

      SortBySelectedSortingAlgorithm(arraySortingMethod, myArray, displaySortingSteps);

      //Selection.sort(myArray, displaySortingSteps);

      Console.WriteLine("Sorted array:");
      PrintArray(myArray);
    }

    private static void SortBySelectedSortingAlgorithm(int sortingAlgorithm, int[] arrayToSort, string displaySteps)
    {
      SelectSortingMethod.SortBySelectedMethod(sortingAlgorithm, arrayToSort, displaySteps);
    }

    private static string AskForSortingStepsDisplay()
    {
      string steps = "n";
      Console.Write("Display sorting steps? [y/n] (default 'n'): ");
      return steps = Console.ReadLine();
    }
    // Prints the array 
    public static void PrintArray(int[] arr)
    {
      int n = arr.Length;
      for (int i = 0; i < n; ++i)
        Console.Write(arr[i] + " ");
      Console.WriteLine();
    }

  }
}