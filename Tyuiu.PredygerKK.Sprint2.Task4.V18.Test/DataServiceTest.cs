using Tyuiu.PredygerKK.Sprint2.Task4.V18.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            double x, y, z;
            x = 3;  y = 3;
            z = 32.667;
            Assert.AreEqual(z, ds.Calculate(x, y));
        }
    }
}