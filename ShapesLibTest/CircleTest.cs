using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ShapesLibTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetSquareTest()
        {
            double radius = 5;
            Сircle сircle = new(radius);
            var expSquare = Math.PI * Math.Pow(radius, 2);
            Assert.AreEqual(сircle.GetSquare(), expSquare);
        }
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void GetSquareZeroRadiusTest()
        {
            //можно сделать вызов исключений при нулевом радиусе
            double radius = 0;
            Сircle сircle = new(radius);
            ValidationContext contex = new ValidationContext(сircle);
            Validator.ValidateObject(сircle, contex);
        }
        [TestMethod]
        public void GetSquareNegativeRadiusTest()
        {
            double radius = -1;
            Сircle сircle = new(radius);
            ValidationContext contex = new ValidationContext(сircle);
            var results = сircle.Validate(contex);
            Assert.AreEqual(results.Count(), 1);
            Assert.AreEqual(results.First().ErrorMessage, "Радиус должен быть больше нуля");
        }
    }
}
