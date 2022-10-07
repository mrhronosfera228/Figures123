using System;

namespace Figures123
{
    public class Triangle : Figure
    {
        public override string Name { get; } = "Треугольник";
        private int firstSide;
        private int secondSide;
        private int thirdSide;
        public Triangle (int a, int b, int c)
        {
            firstSide = a;
            secondSide = b;
            thirdSide = c;
        }

        public override void Calculate()
        {
            double halfPerimetr = (firstSide + secondSide + thirdSide) / 2;
            if (secondSide * secondSide + thirdSide * thirdSide == firstSide * firstSide)
                Console.WriteLine("Площадь треугольника = " + secondSide * thirdSide / 2);
            else if (firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide)
                Console.WriteLine("Площадь треугольника = " + firstSide * secondSide / 2);
            else if (firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide)
                Console.WriteLine("Площадь треугольника = " + firstSide * thirdSide / 2);
            else if (halfPerimetr * (halfPerimetr - firstSide) * (halfPerimetr - secondSide) * (halfPerimetr - thirdSide) >= 0)
                Console.WriteLine("Площадь треугольника = " + Math.Sqrt(halfPerimetr * (halfPerimetr - firstSide) * (halfPerimetr - secondSide) * (halfPerimetr - thirdSide)));
            else
                Console.WriteLine("Такой треугольник не может существовать!");
        }
    }
}
