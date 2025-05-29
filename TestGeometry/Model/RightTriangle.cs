namespace TestGeometry.Model
{
    public class RightTriangle : GeometryElement
    {
        public override double A { get; set; }
        public double H { get; set; }
        /// <summary>
        /// Hypotenuse length value of right triangle.
        /// </summary>
        public double B 
        { 
            get
            {
                return Math.Sqrt(A * A + H * H);
            } 
        }

        public override string Name => throw new NotImplementedException();

        public RightTriangle(double a, double h)
        {
            if (a <= 0 || h <= 0)
            {
                throw new ArgumentException("Значения a и h должны быть положительными");
            }
            else
            {
                A = a;
                H = h;
            }
        }
        public override double GetArea()
        {
            return A * H / 2;
        }

        public override double GetPerimeter()
        {
            return A + H + B;
        }
    }
}
