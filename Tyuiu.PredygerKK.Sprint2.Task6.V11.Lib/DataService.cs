using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PredygerKK.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1 or 3 or 5 or 7 or 8 or 10:
                    if (n == 31) { n = 1; }
                    else { n += 1; }
                    break;

                case 4 or 6 or 9 or 11:
                    if (n == 30) { n = 1; }
                    else { n += 1; }
                    break;

                case 2:
                    if (n == 28) { n = 1; }
                    else { n += 1; }
                    break;

                case 12:
                    if (n == 31) { n = 1; m = 1; g += 1; }
                    else { n += 1; }
                    break;
            }

            if (m < 10 && n < 10) { return $"0{n}.0{m}.{g}"; }
            if (m < 10) { return $"{n}.0{m}.{g}"; }
            if (n < 10) { return $"0{n}.{m}.{g}"; }
            else { return $"{n}.{m}.{g}"; }
        }
           
    }
}
