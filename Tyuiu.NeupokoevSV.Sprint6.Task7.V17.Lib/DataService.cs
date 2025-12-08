using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NeupokoevSV.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            int[,] Matrix = new int[10, 10]
        {
            { 1, -8, 5, -17, -15, -11, -9, 1, 3, 19 },
            { 4, -8, 16, 3, -12, -3, 8, -12, 15, 16 },
            { -15, -1, 10, -7, 8, 2, -20, -1, 2, -1 },
            { -12, 10, -18, -11, -12, -16, -14, 16, 1, -5 },
            { 5, 14, -11, -3, 10, -19, -1, -12, -5, -20 },
            { -7, -16, -4, 0, 10, 4, -3, -7, -7, -17 },
            { -18, 7, -13, -2, 18, -8, -16, 15, 17, 11 },
            { 7, 5, 6, -7, 9, -9, -11, -13, 19, -4 },
            { -5, 14, -2, -9, 18, 16, 20, -14, 7, 17 },
            { -9, 8, 2, 4, -3, -14, 16, 17, -9, 17 }
        };
            int rows = 10;
            int cols = 10;
            int xcol = 2;
            for (int r  = 0; r < rows; r++)
            {
                for (int c = xcol;  c <= cols; c++)
                {
                    if (Matrix[r, c] % 2 == 0)
                    {
                        Matrix[r, c] = 4;
                    }
                }
            }
            return Matrix;
        }

    }
}
