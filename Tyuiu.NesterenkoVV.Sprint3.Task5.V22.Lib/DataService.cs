﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NesterenkoVV.Sprint3.Task5.V22.Lib
{
    public class DataService : ISprint3Task5V22
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sum += (8 * Math.Sin(j)) + 2;
                }
            }
            return  Math.Round(sum, 3);
        }
    }
}
