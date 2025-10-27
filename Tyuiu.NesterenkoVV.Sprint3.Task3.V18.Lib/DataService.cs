using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NesterenkoVV.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task4V18
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue <= stopValue)
            {
                if (startValue == 0)
                {
                    break;
                }
                sum += Math.Sin(startValue) / Math.Cos(startValue);
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
