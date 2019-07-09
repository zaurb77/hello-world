using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson01.DZ;
using Lesson01.MyApps;

namespace Lesson01
{
  class Program
  {
    static void Main(string[] args)
    {
      #region LessonFiles

      // Изучение ref и out
      //Class01RefOut.RefOut();

      // Изучение params
      //Class02Params.ParamsTest();

      // Изучение рекурсии
      //Class03Factorial.MyFactorial();

      #endregion

      /*
       Задача 1.
       Пользователь вводит две буквы. Вывести на экран все буквы от А до Б при помощи рекурсии.
       */
       DZ1.Letters();


      Console.ReadKey();
    }
  }
}
