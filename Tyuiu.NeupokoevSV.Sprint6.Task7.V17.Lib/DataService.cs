using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NeupokoevSV.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] array = new int[rows, cols];
            for (int i  = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            
            int xcol = 2;
            for (int r  = 0; r < rows; r++)
            {
                for (int c = xcol;  c <= cols; c++)
                {
                    if (array[r, c] % 2 == 0)
                    {
                        array[r, c] = 4;
                    }
                }
            }
            return array;
        }

    }
}
