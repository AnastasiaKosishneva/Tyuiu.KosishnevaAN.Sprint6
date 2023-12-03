using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosishnevaAN.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x), 2);

                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}
