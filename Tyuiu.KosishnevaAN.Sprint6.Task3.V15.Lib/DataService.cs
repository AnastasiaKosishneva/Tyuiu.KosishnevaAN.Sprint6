using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosishnevaAN.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {

            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, 2] < matrix[i, 3])
                    {
                        int temp = matrix[i, 2];
                        matrix[i, 2] = matrix[j, 2];
                        matrix[j, 2] = temp;
                    }
                }
            }
            return matrix;
        }
    }
}
