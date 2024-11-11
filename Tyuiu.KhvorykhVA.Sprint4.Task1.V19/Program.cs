using Tyuiu.KhvorykhVA.Sprint4.Task1.V19.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[12];

            Console.WriteLine("Введите 12 целых чисел в диапазоне от 2 до 9:");

            for (int i = 0; i < numsArray.Length; i++)
            {
                int input;
                bool isValidInput;

                do
                {
                    Console.Write($"Введите элемент {i + 1}: ");
                    isValidInput = int.TryParse(Console.ReadLine(), out input) && input >= 2 && input <= 9;

                    if (!isValidInput)
                    {
                        Console.WriteLine("Ошибка! Введите целое число от 2 до 9.");
                    }
                } while (!isValidInput);

                numsArray[i] = input;
            }

            int sumEven = 0;
            foreach (int num in numsArray)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
            }

            Console.WriteLine("\nИсходный массив: ");
            foreach (int num in numsArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nСумма чётных элементов массива: {sumEven}");
            Console.ReadKey();
        }
    }
}
