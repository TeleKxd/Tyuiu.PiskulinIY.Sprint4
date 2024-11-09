using Tyuiu.PiskulinIY.Sprint4.Task2.V26.Lib;
namespace Tyuiu.PiskulinIY.Sprint4.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();
            DataService ds  = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Пискулин Игорь Юрьевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат, и печатает его на экране.                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsarray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsarray[i] = rmd.Next(1, 8);
            }

            Console.WriteLine("массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsarray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsarray);

            Console.WriteLine("произведение = " + res);
            Console.ReadKey();

        }
    }
}
