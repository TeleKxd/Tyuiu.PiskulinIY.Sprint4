
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PiskulinIY.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length == 4);
            return res;
        }
    }
}
