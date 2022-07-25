using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Circle_Objects
{
    internal class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        [Required]
        [Range(0, 10)]
        public double Radius { get; private set; }
    }
}
