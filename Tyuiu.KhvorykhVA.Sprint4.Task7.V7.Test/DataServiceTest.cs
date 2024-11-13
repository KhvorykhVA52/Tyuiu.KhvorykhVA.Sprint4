using Tyuiu.KhvorykhVA.Sprint4.Task7.V7.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            string input = "31415926";
            int oddCount = ds.Calculate(4, 2, input);

            Assert.AreEqual(5, oddCount);
        }
    }
}