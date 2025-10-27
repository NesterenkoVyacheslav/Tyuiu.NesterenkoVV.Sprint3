using Tyuiu.NesterenkoVV.Sprint3.Task2.V9.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int k = 1;
            int stop = 10;
            var res = ds.GetSumSeries(n, k, stop);
            double wait = 0.042;
            Assert.AreEqual(wait, res);
        }
    }
}
