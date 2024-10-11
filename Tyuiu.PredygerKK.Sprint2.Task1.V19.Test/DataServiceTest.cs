using Tyuiu.PredygerKK.Sprint2.Task1.V19.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int a, b, c, d;
            a = 696;
            b = 354;
            c = 423;
            d = 957;
            bool[] res = new bool[6];
            bool[] except = new bool[6] {false, false, false, false, false, false};

            CollectionAssert.AreEquivalent(except, res);
        }
    }
}