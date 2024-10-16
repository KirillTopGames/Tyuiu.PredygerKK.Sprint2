using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PredygerKK.Sprint2.Task2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int a = n;
            switch(n) 
            {
                case 1:
                    n = 31;
                    break;

                default:
                    n -= 1; break;
            }

            switch (m) 
            {
                case 2:
                    n -= 2;
                    break;

                case 4 or 6 or 9 or 11:
                    n -= 1;
                    break;

                case 1:
                    if (a == 1) { m = 12; g -= 1; }
                    else { m = m; }
                    break;

                default:
                    n = n;
                    break;
            }
            return $"{g}.{m}.{n}";
        }
    }
}
