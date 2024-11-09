using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PiskulinIY.Sprint4.Task2.V26.Lib
{
    public class DataService : ISprint4Task2V26
    {
        public int Calculate(int[] array)
        {
            int s = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    s *= array[i];
                }

            }
            return s;
        }
    }
}
