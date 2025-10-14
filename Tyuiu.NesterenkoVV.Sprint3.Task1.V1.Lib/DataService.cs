using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NesterenkoVV.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double mult = 1;
            double i = startValue;
            while (i <= stopValue)
            {
                mult = mult * Math.Pow((3 / i), -2);
                i++;
            }
            return Math.Round(mult, 3);
        }
    }
}
