using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NeupokoevSV.Sprint6.Task2.V2.Lib
{
    public class DataService : ISprint6Task2V2
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
                if ((3 * x + 0.5) != 0)
                {
                    y = Math.Round((Math.Sin(x) + (2/ ( 3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x), 2);
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
