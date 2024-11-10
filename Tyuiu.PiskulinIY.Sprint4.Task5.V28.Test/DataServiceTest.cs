using Tyuiu.PiskulinIY.Sprint4.Task5.V28.Lib;
namespace Tyuiu.PiskulinIY.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {{ -1,1,2,3,4},
                                           { 1,2,3,4,-1},
                                           { -1,1,2,3,4},
                                           { 1,2,3,4,-1},
                                           { -1,1,2,3,4} };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { {0,1,2,3,4 },
                            {1,2,3,4,0 },
                            {0,1,2,3,4 },
                            {1,2,3,4,0 },
                            {0,1,2,3,4 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}