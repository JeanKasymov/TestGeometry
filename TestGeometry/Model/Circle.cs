using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Shapes;

namespace TestGeometry.Model
{
    /// <summary>
    /// Represents a 2D circle
    /// </summary>
    public partial class Circle : ObservableObject, IGeometry2D
    {
        [ObservableProperty]
        private double _r;
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private Shape _geomShape;
        /// Creates a new instance of circle
        /// </summary>
        /// <param name="r">radius of a circle</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Значение a должно быть положительным");
            }
            else
            {
                R = r;
            }
            Name = "Круг";
        }

        public void Create(params object[] inputs)
        {
            GeomShape = new Ellipse() { Height =  (double)inputs[0], Width = (double)inputs[0] };
        }

        [RelayCommand]
        public double GetArea() => Math.PI * Math.Sqrt(R);
        [RelayCommand]
        public double GetPerimeter() => 2 * Math.PI * R;
    }
}
