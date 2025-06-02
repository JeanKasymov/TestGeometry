using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Shapes;
using TestGeometry.Model;

namespace TestGeometry.VM
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<IGeometry2D> _geometryElements;

        [ObservableProperty]
        private Shape _geomShape;

        public MainWindowVM()
        {
            //GeometryElements = new ObservableCollection<IGeometry2D>()
            //{
            //    new Circle()
            //}
        }

        [RelayCommand]
        public void CreateCircle()
        {
            GeomShape = new Ellipse() { Height = 5, Width = 5 };
        }

        [RelayCommand]
        public void CreateShape()
        {
            GeomShape = new ();
        }

    }
}