using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //: - dziedziczenie
    public  class Shape1D : Shape
    {
        public int Width { get; }

        //base - wywołanie konstruktora klasy bazowej
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        //base - odwołanie się do implementracji z klasy bazowej
        public override string ToString()
        {
            return $"{base.ToString()} o szerokości {Width}";
        }
    }
}
