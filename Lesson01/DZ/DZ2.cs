using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.DZ
{
  class DZ2
  {
    //Задача 2 - Рекурсия
    //*
    //**
    //***
    //****
    //*****

    public static void Figures()
    {
      int ROWS = 10;
      char GRAPHCHAR = '*';

      Figure1(ROWS, GRAPHCHAR);
      Figure2(ROWS, GRAPHCHAR);
      Figure3(ROWS, GRAPHCHAR);
      Figure4(ROWS, GRAPHCHAR);
    }

    private static void Figure4(int rows, char graphchar)
    {
      throw new NotImplementedException();
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
    }
  }
}
