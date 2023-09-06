using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Triangle : IShape
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public bool IsTriangleExist => GetIsTriangleExist();
        public bool IsRightTriangle => GetIsRightTriangle();
        public Triangle(double sideA, double sideB, double sideC) => (SideA, SideB, SideC) = (sideA, sideB, sideC);
        public double GetPerimeter() => SideA + SideB + SideC;
        public virtual double GetSquare()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше нуля");
            }
            double semiperimeter = (SideA + SideB + SideC) / 2d;
            return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
        }
        private bool GetIsTriangleExist() => SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        private bool GetIsRightTriangle()
        {
            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            //тут может понадобиться точность, например так: Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
