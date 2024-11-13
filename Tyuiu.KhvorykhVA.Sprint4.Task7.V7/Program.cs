using Tyuiu.KhvorykhVA.Sprint4.Task7.V7.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "31415926";
            DataService ds = new DataService();
            int oddCount = ds.Calculate(4, 2, input);

            Console.WriteLine($"Количество нечетных чисел в матрице {oddCount}");
        }
    }
}