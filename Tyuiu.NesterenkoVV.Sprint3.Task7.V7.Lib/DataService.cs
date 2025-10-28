using System.Xml;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NesterenkoVV.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count=0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == -2)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double z = Math.Cos(i) + ((Math.Cos(i)) / (i + 2)) - 3 * i;
                    valueArray[count]=Math.Round(z, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
