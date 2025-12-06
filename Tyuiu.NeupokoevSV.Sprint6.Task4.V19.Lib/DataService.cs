using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NeupokoevSV.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] value;
            int len = (stopValue - startValue) + 1;
            value = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) - 2) != 0)
                {
                    y = Math.Round(((5*x + 2.5) / (Math.Sin(x) -2) + 2), 2);
                    value[c] = y;
                }
                else
                {
                    value[c] = 0;
                }
                c++;
            }
            return value;
        }
    }
}
