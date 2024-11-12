using Tyuiu.KhvorykhVA.Sprint4.Task4.V14.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы массива 5x5 (числа от 1 до 8):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] resultMatrix = ds.Calculate(matrix);

            Console.WriteLine("\nРезультирующий массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}