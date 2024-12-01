using System;

class Program
{
    // y = x^2 / (x - 1) + sqrt(x + 1)
    static double CalculateFunction(double x)
    {
        if (x == 1)  // Проверка на деление на 0
        {
            throw new Exception("x не может быть 1, деление на ноль невозможно.");
        }
        return (x * x) / (x - 1) + Math.Sqrt(x + 1);
    }

    static void Main()
    {
        // Диапазон значений
        double x = -1.5;
        double step = 0.5;
        double maxX = 4.0;

        // Вывод таблицы
        Console.WriteLine("x\t\t y");
        Console.WriteLine("------------------------");

        // Цикл для вычисления и вывода значений функции
        while (x <= maxX)
        {
            try
            {
                double y = CalculateFunction(x);
                Console.WriteLine($"{x:F1}\t {y:F4}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"x = {x:F1}: {ex.Message}");
            }
            x += step;
        }
    }
}
//привет гитхаб