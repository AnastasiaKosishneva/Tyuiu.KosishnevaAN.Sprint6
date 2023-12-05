using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.KosishnevaAN.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }

            }
            double[] array = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    array[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            array = array.Where(var => var % 1 != 0).ToArray();
            return array;


        }
    }
}
