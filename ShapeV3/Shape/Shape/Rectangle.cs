using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Rectangle : IShape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Rectangle()
        {
            _width = 0;
            _height = 0;
        }

        public Rectangle(double Width, double Height)
        {
            _width = Width;
            _height = Height;
        }

        public double Area()
        {
            return _width * _height;
        }

        public double Circumference()
        {
            return 2 * (_width + _height);
        }
    }
}
