using Tyuiu.KhvorykhVA.Sprint4.Task6.V15.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            string[] testArray = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int result = ds.Calculate(testArray);
            Assert.AreEqual(3, result); 
        }
    }
}