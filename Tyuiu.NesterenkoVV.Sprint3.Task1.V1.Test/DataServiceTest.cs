using Tyuiu.NesterenkoVV.Sprint3.Task1.V1.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 3;
            double wait =0.049 ;
            var res = ds.GetMultiplySeries(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
