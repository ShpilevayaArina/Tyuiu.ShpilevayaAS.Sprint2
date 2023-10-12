using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShpilevayaAS.Sprint2.Task1.V16.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c > d);
            res[1] = (a + 2 < b) & (c > d);
            res[2] = (a < b) || (c > d);
            res[3] = (a + 2 > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a < b) ^ (c > d);

            return res;

        }
    }
}
