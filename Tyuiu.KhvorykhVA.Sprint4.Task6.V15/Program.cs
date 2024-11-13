using Tyuiu.KhvorykhVA.Sprint4.Task6.V15.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            DataService ds = new DataService();
            int result = ds.Calculate(cities);
            Console.WriteLine($"Количество элементов с длиной меньше 7: {result}");
        }
    }
}