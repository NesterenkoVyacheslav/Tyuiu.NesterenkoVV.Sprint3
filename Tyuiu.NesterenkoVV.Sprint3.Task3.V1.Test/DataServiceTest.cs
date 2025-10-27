using Tyuiu.NesterenkoVV.Sprint3.Task3.V1.Lib;
namespace Tyuiu.NesterenkoVV.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            char a = 'a';
            string z = "have a nice time";
            var res = ds.GetCharCount(z, a);
            Assert.AreEqual(2, res);
        }
    }
}
