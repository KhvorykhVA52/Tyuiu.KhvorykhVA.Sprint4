using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhvorykhVA.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
                throw new ArgumentException("Длина строки должна совпадать с размером матрицы.");

            int[,] matrix = new int[n, m];
            int oddCount = 0;

            for (int i = 0; i < value.Length; i++)
            {
                int row = i / m;
                int col = i % m;
                int number = int.Parse(value[i].ToString());
                matrix[row, col] = number;

                if (number % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }
    }
}
