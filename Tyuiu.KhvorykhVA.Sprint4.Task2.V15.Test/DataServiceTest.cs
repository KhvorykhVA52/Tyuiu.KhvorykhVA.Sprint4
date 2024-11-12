using Tyuiu.KhvorykhVA.Sprint4.Task2.V15.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 6 };
            int res = ds.Calculate(numsArray);
            int wait = 12;
                Assert.AreEqual(wait, res);
            
        }
    }
}