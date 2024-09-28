using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MiliukovLO.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                result = Math.PI * Math.Pow((i/Math.Pow(Math.Sin(1),-7)),-2);
            }
            return result;
        }
    }
}
