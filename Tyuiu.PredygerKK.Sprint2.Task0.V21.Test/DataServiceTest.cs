using Tyuiu.PredygerKK.Sprint2.Task0.V21.Lib;

namespace Tyuiu.PredygerKK.Sprint2.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int x, y;
            x = 1705;
            y = 775;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] expect = new bool[6] {false, false, false, false, false, false};
            CollectionAssert.AreEqual(expect, res);
        }
    }
}