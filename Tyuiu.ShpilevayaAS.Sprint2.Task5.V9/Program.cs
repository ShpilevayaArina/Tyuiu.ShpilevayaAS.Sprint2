using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShpilevayaAS.Sprint2.Task5.V9.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Шпилевая А. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m определить   *");
            Console.WriteLine("* дату следующего дня (принять, что n и m не характеризуют 31 декабря).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число: ");
            int numCH = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int numM = Convert.ToInt32(Console.ReadLine());

            string res;
            string prres;
            int pr;
            int month;
            int date;

            if ((numM < 1) || (numM > 12))
            {
                res = "Введено неверное значение месяца!";
            }
            else
            {
                if ((numCH < 1) || (numCH > 31))
                {
                    res = "Введено неверное значение даты!";
                }
                else
                {
                    pr = ds.FindDateOfNextDay(numCH, numM);
                    prres = pr.ToString();
                    if (prres.Length == 3)
                    {
                        res = prres[0] + "." + prres[1] + prres[2];
                    }
                    else
                    {
                        month = pr % 100;
                        date = pr / 100;
                        res = date.ToString() + "." + month.ToString();

                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
