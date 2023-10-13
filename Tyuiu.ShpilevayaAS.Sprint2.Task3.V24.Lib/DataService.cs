using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task3.V24.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y =  x * Math.Pow( ( (10 + Math.Sin(Math.Sqrt(x + 1))) / x) , x);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Cos(x) + (12 / Math.Pow(x, 2));
                }
                else
                {
                    if ((x > -28) && (x < 0))
                    {
                        y = Math.Pow((1 + (1 / (Math.Pow(x, 2)))), x);
                    }
                    else
                    {
                        if (x < -28)
                        {
                            y = Math.Pow(x, 2) + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
