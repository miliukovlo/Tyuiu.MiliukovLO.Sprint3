using Tyuiu.MiliukovLO.Sprint3.Task7.V9.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #3 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                                ");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  ");
        Console.WriteLine("* Задание #7                                                               ");
        Console.WriteLine("* Вариант #9                                                               ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции             ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Введите значние х:                                                       ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        double[] result = ds.GetMassFunction(x, y);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        Console.ReadKey();
    }
}