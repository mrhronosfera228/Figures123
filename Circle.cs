using System;

namespace Figures123
{
    public class Circle : Figure
    {
        public override string Name { get; } = "Круг";
        private int radius;

        public Circle(int x) {
            radius = x;
        }

        public override void Calculate() =>
            Console.WriteLine("Площадь круга: " + (Math.PI * Math.Pow(radius, 2)));
    }
}
