﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MiliukovLO.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += (Math.Pow(value, i) + 1) * Math.Cos(i);
            }
            return sumSeries;
        }
    }
}
