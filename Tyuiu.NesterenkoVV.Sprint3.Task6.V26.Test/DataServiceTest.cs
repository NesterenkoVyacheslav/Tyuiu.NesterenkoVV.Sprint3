using Tyuiu.NesterenkoVV.Sprint3.Task6.V26.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 22;
            int res = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(33, res);
        }
    }
}
