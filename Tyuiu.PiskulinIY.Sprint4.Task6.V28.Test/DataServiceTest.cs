using Tyuiu.PiskulinIY.Sprint4.Task6.V28.Lib;
namespace Tyuiu.PiskulinIY.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Река", "Лужа", "Море" };
            CollectionAssert.AreEqual(wait, res);


        }
    }
}