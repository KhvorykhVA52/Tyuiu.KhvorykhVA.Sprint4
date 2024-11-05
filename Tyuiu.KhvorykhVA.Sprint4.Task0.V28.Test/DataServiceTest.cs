using Tyuiu.KhvorykhVA.Sprint4.Task0.V28.Lib;
namespace Tyuiu.KhvorykhVA.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int wait = 4608;
                Assert.AreEqual(wait, res);



        }
           
    }
}