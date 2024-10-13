using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PredygerKK.Sprint2.Task3.V18.Lib
{
    public class DataService : ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            if (x > 1) 
            {
                return Math.Round((x * x) * Math.Pow((x + 1) / (x - 1), x), 3);
            }

            if (x == 0)
            {
                return Math.Round((x*x - Math.Cos(x*x) + 10) / (x*x - Math.Sin(x*x) + 12), 3);
            }

            if (x > -22 && x < 2) 
            {
                return Math.Round(Math.Pow(1 + 1/(x*x), x), 3);
            }

            if (x < -22)
            {
                return Math.Round(x + 10 * x - 1 / x, 3);
            }
            else { return 0; }
        }
    }
}
