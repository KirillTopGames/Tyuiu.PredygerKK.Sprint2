using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PredygerKK.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //a = 696, b = 354, c = 423, d = 957

            bool[] res = new bool[6];

            res[0] = (a > b) | (c == d); //true
            res[1] = (a < b) & (c > d); //false
            res[2] = (a != d) || (b > c); //true
            res[3] = (b < c) && (a > d); //false
            res[4] = !(a == c); //true
            res[5] = (d > c)^(c > b); //false

            return res;
        }
    }
}
