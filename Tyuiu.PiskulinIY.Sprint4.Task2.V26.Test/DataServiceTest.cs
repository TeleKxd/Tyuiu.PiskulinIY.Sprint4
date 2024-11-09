using Tyuiu.PiskulinIY.Sprint4.Task2.V26.Lib;
namespace Tyuiu.PiskulinIY.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsarray = { 2,3,7,8 };
            int res = ds.Calculate(numsarray);
            int wait = 21;
            Assert.AreEqual(wait, res);
        }
    }
}