using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PredygerKK.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (((x >= 3 && x <= 5) || (x >= 9 && x <= 12)) && (y >= 3 && y <= 4)) res = true;

            if ((x >= 3 && x <= 12) && (y >= 5 && y <= 7)) res = true;

            if (x == 13 && (y >= 6 && y <= 7)) res = true;

            if (x == 4 && y == 8) res = true;

            if ((x >= 6 && x <= 13) && y == 8) res = true;

            if (x == 4 && y == 9) res = true;

            if ((x >= 6 && x <= 9) && y == 9) res = true;

            if ((y >= 10 && y <= 12) && (x >= 8 && x <= 9)) res = true;

            if ((x == 4) && (y >= 3 && y <= 14)) res = true;

            if (y == 11 && (x >= 3 && x <= 5)) res = true;

            if (y == 14 && (x >= 2 && x <= 6)) res = true;

            return res;

        }
    }
}
