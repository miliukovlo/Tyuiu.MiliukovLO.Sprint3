using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MiliukovLO.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if(i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
