namespace TestGeometry.Model
{
    public class Rectangle : GeometryElement
    {
        public override double A { get; set; }

        public double B { get; set; }

        public override string Name => throw new NotImplementedException();

        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Значения a и h должны быть положительными");
            }
            else
            {
                A = a;
                B = b;
            }
        }
        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return (A + B) * 2;
        }
    }
}
