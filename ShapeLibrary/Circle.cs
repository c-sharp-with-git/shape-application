using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Invald radius");
                radius = value;
            }
        }

        public Circle()
        {
            radius = 0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

    }
}
