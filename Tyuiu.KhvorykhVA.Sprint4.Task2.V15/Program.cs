using Tyuiu.KhvorykhVA.Sprint4.Task2.V15.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[11];
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(2, 8);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine("Сумма четных элементов массива: " + sum);
        }
    }
}
