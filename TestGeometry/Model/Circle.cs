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
            GeomShape = new Ellipse() { Height = r, Width = r };
        }

        public void Create(params object[] inputs)
        {
            throw new NotImplementedException();
        }

        [RelayCommand]
        public double GetArea()
        {
            return Math.PI * Math.Sqrt(R);
        }
        [RelayCommand]
        public double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
    }
}
