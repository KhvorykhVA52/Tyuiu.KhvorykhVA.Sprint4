using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhvorykhVA.Sprint4.Task1.V19.Lib
{
    public class DataService : ISprint4Task1V19
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0) 
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}