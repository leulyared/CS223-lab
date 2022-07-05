using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_area_and_perimeter
{
    interface shape
    {
        double getArea();
        double getPerimter();

    }

    abstract class shape1
    {
        public abstract double getArea();
        public abstract double getPerimter();
    }

    class circle : shape
    {
        public double radius { get; set; }
        static double PI = 3.14;
        public double getArea()
        {
            return PI * radius * radius;
        }

        public double getPerimter()
        {
            return 2 * PI * radius;
        }
    }

    class triangle : shape1
    {
        public double height { get; set; }
        public double bases { get; set; }
        public double side { get; set; }
        public override double getArea()
        {
            return 0.5 * (bases * height);
        }

        public override double getPerimter()
        {
            return height + bases + side;
        }
    }

    class square : shape
    {
        public double side;
        public double getArea()
        {
            return side * side;
        }

        public double getPerimter()
        {
            return 4 * side;
        }

        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
