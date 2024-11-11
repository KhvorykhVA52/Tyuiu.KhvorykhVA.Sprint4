using Tyuiu.KhvorykhVA.Sprint4.Task1.V19.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] array = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.Calculate(array);
            Assert.AreEqual(26, res);
        }
    }
}