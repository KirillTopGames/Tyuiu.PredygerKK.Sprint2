using Tyuiu.PredygerKK.Sprint2.Task2.V10.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int x, y;
            x = 10; y = 4;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}