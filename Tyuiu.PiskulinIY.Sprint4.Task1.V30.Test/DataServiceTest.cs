using Tyuiu.PiskulinIY.Sprint4.Task1.V30.Lib;
namespace Tyuiu.PiskulinIY.Sprint4.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsarray = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
            int res = ds.Calculate(numsarray);
            int wait = 13824;
            Assert.AreEqual(wait, res);

        }
    }
}