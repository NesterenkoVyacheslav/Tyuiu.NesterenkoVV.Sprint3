using Tyuiu.NesterenkoVV.Sprint3.Task0.V27.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int startvalue = 1;
            int stopvalue = 13;
            double wait = 16.016;
            var res = ds.GetSumSeries(n, startvalue, stopvalue);
            Assert.AreEqual(wait, res);

        }
    }
}
