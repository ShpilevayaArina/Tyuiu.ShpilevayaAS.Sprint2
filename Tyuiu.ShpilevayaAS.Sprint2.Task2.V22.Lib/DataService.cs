using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task2.V22.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = new bool();

            if ((x >= 3) && (x <=13) && (y >=3) && (y <= 14))
            {
                if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7))
                {
                    res = true;
                }
                if ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 4))
                {
                    res = true;
                }
                if ((x >= 6) && (x <= 12) && (y >= 5) && (y <= 7))
                {
                    res = true;
                }
                if ((x >= 13) && (x <= 13) && (y >= 6) && (y <= 8))
                {
                    res = true;
                }
                if ((x >= 12) && (x <= 12) && (y >= 8) && (y <= 11))
                {
                    res = true;
                }
                if ((x >= 9) && (x <= 10) && (y >= 8) && (y <= 9))
                {
                    res = true;
                }
                if ((x >= 4) && (x <= 6) && (y >= 8) && (y <= 11))
                {
                    res = true;
                }
                if ((x >= 3) && (x <= 3) && (y >=11) && (y <= 11))
                {
                    res = true;
                }
                if ((x >= 5) && (x <= 5) && (y >= 12) && (y <= 13))
                {
                    res = true;
                }
                if ((x >= 4) && (x <= 10) && (y >= 14) && (y <= 14))
                {
                    res = true;
                }
            }
            else
            {
                res = false;
            }

            return res;

        }
    }
}
