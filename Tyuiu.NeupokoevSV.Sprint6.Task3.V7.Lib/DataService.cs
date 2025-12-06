using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NeupokoevSV.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.Length / rows;
            int[,] result = new int[rows, cols];
            Array.Copy(matrix, result, matrix.Length);
            if (cols >= 4)
            {
                SortColumn(result,  3);
            }
            return result;

        }
        private void SortColumn(int[,] matrix, int columnIndex)
        {
            int rows = matrix.GetLength(0);

            // Извлекаем значения столбца в отдельный массив
            int[] columnValues = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                columnValues[i] = matrix[i, columnIndex];
            }

            // Сортируем значения столбца по возрастанию
            Array.Sort(columnValues);

            // Записываем отсортированные значения обратно в столбец
            for (int i = 0; i < rows; i++)
            {
                matrix[i, columnIndex] = columnValues[i];
            }
        }
    }
}
