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

            string[] array = { "����", "�����", "������", "�����", "����", "����" };
            string[] res = ds.Calculate(array);
            string[] wait = { "����", "����", "����" };
            CollectionAssert.AreEqual(wait, res);


        }
    }
}