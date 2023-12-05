using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosishnevaAN.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                double divisor = 3 * x + 1.2;
                if (Math.Abs(divisor) < 0.000001)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((2 * Math.Sin(x)) / (divisor) + Math.Cos(x) - 7 * x * 2, 2);
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
