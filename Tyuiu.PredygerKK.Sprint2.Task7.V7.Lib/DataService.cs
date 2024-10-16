using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PredygerKK.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if(y <= 2 - x * x && y >= x) { res = true; }
            if (y <= x && y >= 0 && y <= 2 - x*x) { res = true; }

            return res;
        }
    }
}
