using System;

namespace Figures123
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] arr = { new Circle(2), new Triangle(3, 5, 9), new Triangle(2,8,6), new Circle(5), new Triangle(3, 5, 4) };

            foreach (Figure figure in arr)
            {
                PrintInfo(figure);
            }
        }

        static void PrintInfo(Figure figure)
        {
            Console.WriteLine("Название фигуры: {0}", figure.Name);
            figure.Calculate();
            Console.WriteLine("\n");
        }
    }
}
