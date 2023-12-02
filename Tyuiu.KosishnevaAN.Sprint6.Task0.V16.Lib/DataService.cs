using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosishnevaAN.Sprint6.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            double xx = Convert.ToDouble(x);
            double res = Math.Round((1 + xx * xx * xx) / (xx * xx),3);
            string str = res.ToString();
            return str; 
        }
    }
}
