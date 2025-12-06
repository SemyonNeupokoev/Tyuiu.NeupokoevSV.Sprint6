using Tyuiu.NeupokoevSV.Sprint6.Task2.V2.Lib;
namespace Tyuiu.NeupokoevSV.Sprint6.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);

            double[] wait = new double[11];
            wait[0] = 6.49;
            wait[1] = -9.88;
            wait[2] = -12.26;
            wait[3] = -4.6;
            wait[4] = 0.52;
            wait[5] = 4;
            wait[6] = -0.75;
            wait[7] = 4.55;
            wait[8] = 12.23;
            wait[9] = 9.86;
            wait[10] = -6.5;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
