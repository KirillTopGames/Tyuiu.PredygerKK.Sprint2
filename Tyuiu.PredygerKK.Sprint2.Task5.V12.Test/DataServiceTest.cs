using Tyuiu.PredygerKK.Sprint2.Task5.V12.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 1997;
            m = 1;
            n = 1;

            Assert.AreEqual("31.12.1996", ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}