using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeometry.Model
{
    public interface IGeometry2D
    {
        /// <summary>
        /// Method for calculating the area of ​​a 2D element
        /// </summary>
        /// <returns>Returns the numeric value of the area of ​​a 2D element</returns>
        public double GetArea();
        /// <summary>
        /// Method for calculating the perimeter of ​​a 2D element
        /// </summary>
        /// <returns>Returns the numeric value of the perimeter of ​​a 2D element</returns>
        public double GetPerimeter();
        /// <summary>
        /// Method for creating shape of 2D element
        /// </summary>
        public abstract static void Create(params object[] inputs);
    }
}
