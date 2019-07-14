using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.DZ
{
  class DZ1
  {
    //Задача 1
    //Пользователь вводит две буквы.Вывести на экран все буквы от А до Б при помощи рекурсии.

    public static void Letters()
    {
      char a = 'a';
      char b = 'z';

      //PrintCharsLoop(a, b);         // при помощи цикла for
      PrintCharsRecursion(a, b);  // при помощи рекурсии

    }

    private static void PrintCharsRecursion(char x, char y)
    {
      if (x < y)
      {
        Console.Write(x);
        x++;
        PrintCharsRecursion(x,y);
      }
    }

    private static void PrintCharsLoop(char x, char y)
    {
      for (char i = x; i <= y; i++)
      {
        Console.Write(i);
      }
    }
  }
}
