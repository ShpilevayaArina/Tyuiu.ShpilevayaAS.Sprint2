using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShpilevayaAS.Sprint2.Task6.V14.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Шпилевая А. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
            Console.WriteLine("* (понедельником, вторником,…,субботой или воскресеньем) является k-й день*");
            Console.WriteLine("* не високосного года, в котором 1 января d-й день недели(если 1 января   *");
            Console.WriteLine("* понедельник, то d=1 , если вторник — d = 2 ,…, если воскресенье — d = 7)*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня в году (1 - 365):");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня недели 1 января");
            int d = Convert.ToInt32(Console.ReadLine());

            int t = (d + k - 2) % 7;

            string res;

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if ((k > 365) || (k < 1) || (d > 7) || (d < 1))
            {
                Console.WriteLine("Недопустимые значения!");
            }
            else
            {
                res = ds.FindDayName(t);
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
