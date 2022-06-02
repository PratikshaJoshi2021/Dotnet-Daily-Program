using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class PropertiesInClass
    {
        public PropertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private const double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void PrintCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    }
}

