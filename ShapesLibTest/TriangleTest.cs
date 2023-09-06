using ShapesLib;

namespace ShapesLibTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetSquareTest()
        {
            double sideA = 10.08, sideB = 11.76, sideC = 13.02;
            double semiperimeter = (sideA + sideB + sideC) / 2d;
            var expSquare = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            Triangle triangle = new(sideA, sideB, sideC);
            Assert.AreEqual(triangle.GetSquare(), expSquare);
        }
        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(-1, 0, 0)]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquareErrorTest(double sideA, double sideB, double sideC)
        {
            Triangle triangle = new(sideA, sideB, sideC);
            triangle.GetSquare();
        }
        [TestMethod]
        public void GetIsTriangleExistTest()
        {
            Triangle triangle = new(4, 6, 8);
            Assert.IsTrue(triangle.IsTriangleExist);
        }
        [TestMethod]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new(2.1, 2.8, 3.5);
            Assert.IsTrue(triangle.IsTriangleExist);
            Assert.IsTrue(triangle.IsRightTriangle);
        }
    }
}
