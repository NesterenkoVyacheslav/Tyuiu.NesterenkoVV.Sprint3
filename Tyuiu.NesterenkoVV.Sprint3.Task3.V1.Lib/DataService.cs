using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NesterenkoVV.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            int result = 0;
            foreach (char c in value)
            {
                if (c == item)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
