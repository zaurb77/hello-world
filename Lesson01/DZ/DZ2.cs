using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.DZ
{
  class DZ2
  {
    /*Задача 2

    *					******				*			******
    **				*****			   **			 *****
    ***				****				***			  ****
    ****			***			   ****				 ***
    *****			**			  *****				  **
    ******    *        ******          *
     Fig.1	 Fig.2		 Fig.3		   Fig.4
    */

    public static void Figures()
    {
      int ROWS = 10;
      char GRAPHCHAR = '*';

      Console.WriteLine("Draw Fig. 1");
      Console.ReadKey();
      Figure1(ROWS, GRAPHCHAR);
      Console.WriteLine("Draw Fig. 2");
      Console.ReadKey();
      Figure2(ROWS, GRAPHCHAR);
      Console.WriteLine("Draw Fig. 3");
      Console.ReadKey();
      Figure3(ROWS, GRAPHCHAR);
      Console.WriteLine("Draw Fig. 4");
      Console.ReadKey();
      Figure4(ROWS, GRAPHCHAR);
    }

    private static void Figure1(int ROWS, char GRAPHCHAR)
    {
      for (int i = 0; i < ROWS; i++)
      {
        for (int k = 0; k <= i; k++)
        {
          Console.Write(GRAPHCHAR);
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }

    private static void Figure2(int ROWS, char GRAPHCHAR)
    {
      for (int i = ROWS - 1; i >= 0; i--)
      {
        for (int k = 0; k <= i; k++)
        {
          Console.Write(GRAPHCHAR);
        }
        Console.WriteLine();
      }
    }

    private static void Figure3(int ROWS, char GRAPHCHAR)
    {
      for (int row = ROWS; row >= 0; row--)
      {
        var counter = 0;
        for ( counter = 0; counter < row; counter++)
        {
          Console.Write(' ');
        }
        for ( counter = 0; counter < ROWS - row; counter++)
        {
          Console.Write(GRAPHCHAR);
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    private static void Figure4(int rows, char graphchar)
    {
      for (int row = rows; row >= 0; row--)
      {
        var counter = 0;
        for (counter = 0; counter < rows - row; counter++)
        {
          Console.Write(' ');
        }
        for (counter = 0; counter < row; counter++)
        {
          Console.Write(graphchar);
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
