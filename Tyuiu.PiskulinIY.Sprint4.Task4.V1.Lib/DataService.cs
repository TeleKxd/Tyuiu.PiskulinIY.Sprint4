﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PiskulinIY.Sprint4.Task4.V1.Lib
{
    public class DataService : ISprint4Task4V1
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) 
                {
                    if (matrix[i,j] % 2 == 0)
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
