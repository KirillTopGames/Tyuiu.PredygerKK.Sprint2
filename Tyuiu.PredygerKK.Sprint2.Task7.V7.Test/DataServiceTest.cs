using Tyuiu.PredygerKK.Sprint2.Task7.V7.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double x, y;
            x = -1; y = -0.356;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}