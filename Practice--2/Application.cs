using System;
using InputOutputLib;

namespace Practice__2
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение значение функции в заданной точке: {0}.", Function(Get.Double("Введите число a: ")));
            Console.ReadKey();
        }

        private static double Function(Double x)
        {
            if (x <= 0)
                return Math.Abs(x + 1);

            return Math.Abs(x - 1);
        }
    }
}