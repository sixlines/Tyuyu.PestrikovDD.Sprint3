using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PestrikovDD.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] results = new double[size];

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;
                if (4 * x - 0.5 == 0)
                {
                    fx = 0;
                }
                else
                {
                    fx = (3 * Math.Cos(x) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2;
                }
                results[x - startValue] = Math.Round(fx, 2);
            }

            return results;
        }
    }
}
