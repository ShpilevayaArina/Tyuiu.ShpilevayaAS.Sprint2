using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task4.V18.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task4V18
    {
        public double Calculate(double x, double y)
        {
            double z = x * 3 < y - 2 ? Math.Pow((6 + ((x - 1) / Math.Pow(y, 3))), x) : (x + 10 * y - (1 / x));
            return Math.Round(z, 3);
        }
    }
}
