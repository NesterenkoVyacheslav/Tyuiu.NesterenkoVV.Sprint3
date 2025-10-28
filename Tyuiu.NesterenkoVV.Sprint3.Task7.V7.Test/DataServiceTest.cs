using Tyuiu.NesterenkoVV.Sprint3.Task7.V7.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            int len = (y - x) + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 15.19;
            valueWaitArray[1] = 11.67;
            valueWaitArray[2] = 9;
            valueWaitArray[3] = 0;
            valueWaitArray[4] = 4.08;
            valueWaitArray[5] = 1.5;
            valueWaitArray[6] = -2.28;
            valueWaitArray[7] = -6.52;
            valueWaitArray[8] = -10.19;
            valueWaitArray[9] = -12.76;
            valueWaitArray[10] = -14.68;
            var res = ds.GetMassFunction(x, y);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
