using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public interface IShape
    {
        double GetSquare();
    }
    /// <remarks>Под вычислением площади фигуры без знания типа фигуры в compile-time имелось ввиду что-то такое?</remarks>
    public static class Test
    {
        public static double GetShapeSquare()
        {
            IShape shape = new Сircle(5);
            return shape.GetSquare();
        }
    }
}
