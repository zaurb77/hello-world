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
      int depth = 5;
      char image = '°';

      //MapFigure1(depth, image);
      //MapFigure2(depth, image);
      MapFigure3(depth, image);
    }

    private static void MapFigure1(int depth, char image)
    {
      for (int i = 0; i < depth; i++)
      {
        for (int k = 0; k <= i; k++)
        {
          Console.Write(image);
        }
        Console.WriteLine();
      }
    }

    private static void MapFigure2(int depth, char image)
    {
      for (int i = depth-1; i >= 0; i--)
      {
        for (int k = 0; k <= i; k++)
        {
          Console.Write(image);
        }
        Console.WriteLine();
      }
    }

    private static void MapFigure3(int depth, char image)
    {
      for (int i = depth-1; i >=0 ; i--)
      {
        for (int k = i; k >= 0; k--)
        {
          Console.Write(' ');
          if (k<depth-1)
        {
          Console.Write(image);
        }
          
        
        }
        
        
        Console.WriteLine();
      }
    }
  }
}
