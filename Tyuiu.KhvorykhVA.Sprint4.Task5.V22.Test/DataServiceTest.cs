using Tyuiu.KhvorykhVA.Sprint4.Task5.V22.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            var dataService = new DataService();
            int[,] testMatrix = {
                { -1, 2, -3, 4, 5 },
                { 6, -7, 8, -9, 0 },
                { 1, -2, 3, -4, 5 },
                { -6, 7, -8, 9, 0 },
                { 1, -2, 3, -4, -5 }
            };

            int result = dataService.Calculate(testMatrix);

            Assert.AreEqual(11, result); 
        }
    }
}