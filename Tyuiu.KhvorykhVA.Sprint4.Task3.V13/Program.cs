using Tyuiu.KhvorykhVA.Sprint4.Task3.V13.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]
            {
                {4, 7, 4, 2, 1},
                {6, 7, 3, 6, 5},
                {6, 5, 3, 3, 5},
                {4, 4, 6, 4, 7},
                {2, 1, 2, 3, 4}
            };

            DataService ds = new DataService();

            int sum = ds.Calculate(array);

            Console.WriteLine($"Сумма элементов в третьем столбце массива: {sum}");
        }
    }
}
