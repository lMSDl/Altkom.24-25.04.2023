using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Triangle : Shape2D, IColor
    {
        public int Angle { get; }
        public Triangle(int width, int height, int angle) : base("Trójkąt", width, height)
        {
            Angle = angle;
        }



        public override string ToString()
        {
            return $"{base.ToString()} oraz kącie między bokami {Angle}";
        }

        public override double CalculateArea()
        {
            return Width * Height * Math.Cos(Angle);
        }

        public string Color { get; set; }
    }
}
