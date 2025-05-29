using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeometry.Model
{
    public interface IGeometry2DElement
    {
        /// <summary>
        /// Method for calculating the area of ​​a 2D element
        /// </summary>
        /// <returns>Returns the numeric value of the area of ​​a 2D element</returns>
        public double GetArea();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter();
    }
}
