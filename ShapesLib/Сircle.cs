using System.ComponentModel.DataAnnotations;
namespace ShapesLib
{
    public class Сircle : IShape, IValidatableObject
    {
        public double Radius { get; init; }
        public Сircle(double radius) => Radius = radius;
        public double GetPerimeter() => 2 * Math.PI * Radius;
        public virtual double GetSquare() => Math.PI * Math.Pow(Radius, 2);
        /// <summary>
        /// Для разнообразия
        /// </summary>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Radius <= 0)
            {
                errors.Add(new ValidationResult("Радиус должен быть больше нуля"));
            }
            return errors;
        }
    }
}
