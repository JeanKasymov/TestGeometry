using CommunityToolkit.Mvvm.ComponentModel;

namespace TestGeometry.Model
{
    public partial class Square : ObservableObject, IGeometry2D
    {
        [ObservableProperty]
        private double _a;
        [ObservableProperty]
        private string name = "Квадрат";
        public Square(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Значение a должно быть положительным");
            }
            else
            {
                A = a;
            }
        }

        public double GetArea()
        {
            return Math.Sqrt(A);
        }

        public double GetPerimeter()
        {
            return A * 4;
        }
    }
}