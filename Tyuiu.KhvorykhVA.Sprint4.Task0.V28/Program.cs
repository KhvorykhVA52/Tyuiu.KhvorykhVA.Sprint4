using Tyuiu.KhvorykhVA.Sprint4.Task0.V28.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds  = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            Console.WriteLine("Исходный массив: ");
            foreach (int num in numsArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int result = ds.GetMultEvenArrEl(numsArray);
            Console.WriteLine("Сумма четных элементов массива: " + result);
            Console.ReadKey();


        }




    }


}