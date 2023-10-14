using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task6.V14.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task6V14
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 0: return "Понедельник";
                case 1: return "Вторник";
                case 2: return "Среда";
                case 3: return "Четверг";
                case 4: return "Пятница";
                case 5: return "Суббота";
                case 6: return "Воскресенье";
                default: throw new ArgumentException($"Недопустимый день недели");


            }
        }
    }
}
