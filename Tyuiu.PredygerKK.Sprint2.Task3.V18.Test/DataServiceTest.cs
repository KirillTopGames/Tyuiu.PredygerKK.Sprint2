using Tyuiu.PredygerKK.Sprint2.Task3.V18.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {

            DataService ds = new DataService();
            double x,y;
            y = 0.946;
            x = -18;
           
            Assert.AreEqual(y, ds.Calculate(x));
        }
    }
}