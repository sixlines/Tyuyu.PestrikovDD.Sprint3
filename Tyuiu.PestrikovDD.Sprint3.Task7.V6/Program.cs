using Tyuiu.PestrikovDD.Sprint3.Task7.V6.Lib;
namespace Tyuiu.PestrikovDD.Sprint3.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Пестриков Д. Д. | ИСТНБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Пестриков Д. Д. | ИСТНБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность операций не должна нарушаться) и арифметических выражений, кот*");
            Console.WriteLine("*торая вернет логическую последовательность(массив): (True, True, True, Tr*");
            Console.WriteLine("*rue, True, False), при x = 1054, y = 375                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetMassFunction(2, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}