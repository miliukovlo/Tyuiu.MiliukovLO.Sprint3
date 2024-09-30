using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MiliukovLO.Sprint3.Task4.V14.Lib
{
    public class DataService : ISprint3Task4V14
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                result += Math.Cos(i) / Math.Sin(i);
            }
            return result;
        }
    }
}
