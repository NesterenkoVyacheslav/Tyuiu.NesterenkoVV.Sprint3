using Tyuiu.NesterenkoVV.Sprint3.Task4.V18.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task4.V18.Test
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
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.993, res);
        }
    }
}