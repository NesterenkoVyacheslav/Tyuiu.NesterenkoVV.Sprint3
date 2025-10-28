using Tyuiu.NesterenkoVV.Sprint3.Task5.V22.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int Imin = 1;
            int Imax = 3;
            int Kmin = 1;
            int Kmax = 12;
            int x = 2;
            var res = ds.GetSumSumSeries(x, Imin, Kmin, Imax, Kmax);
            Assert.AreEqual(68.991, res);
        }
    }
}
