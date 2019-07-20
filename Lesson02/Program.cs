using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson02.Lesson;
using Lesson02.Sorting.Algorithms;
namespace Lesson02
{
  class Program
  {

    static void Main(string[] args)
    {
    
      Sorting.Algorithms.Selection.Sort();
      
      //Lesson._01Arrays.Arrays();
      
      User a = new User();

      a.userName = "zaur123";
      a.fName = "zaur";

      User b = new User();
      b = a;
      
      b.userName = "mihail123";
      //b.fName = "mihail";

      Console.WriteLine($"a.userName = {b.userName}, b.fname = {b.fName}");

      Console.ReadKey();
    }
  }
}
