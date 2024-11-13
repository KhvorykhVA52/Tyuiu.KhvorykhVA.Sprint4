using Tyuiu.KhvorykhVA.Sprint4.Task5.V22.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-8, 10);
                }
            }

            DataService dataService = new DataService();
            int negativeCount = dataService.Calculate(matrix);

            Console.WriteLine("Количество отрицательных элементов: " + negativeCount);
        }
    }
}