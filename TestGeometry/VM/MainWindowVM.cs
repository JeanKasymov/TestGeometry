using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TestGeometry.Model;

namespace TestGeometry.VM
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<IGeometry2DElement> _geometryElements;
        public MainWindowVM()
        {
            GeometryElements = new ObservableCollection<IGeometry2DElement>()
            {
                new Circle()
            }
        }
    }
}
