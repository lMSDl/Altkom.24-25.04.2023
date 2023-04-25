using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public abstract class Shape2D : Shape1D
    {
        public Shape2D(string name, int width, int height) : base(name, width)
        {
            Height = height;
        }

        public int Height { get; }

        public override string ToString()
        {
            return $"{base.ToString()} i wysokości {Height}";
        }


        //metoda abstrakcyjna - nie posiada ciałą i MUSI mieć implenetację w klasach pochodnych
        //Jeśli klasa posiada metodę abstrakcyjną to ta klasa musi być też abstrakcyjna
        public abstract double CalculateArea();
    }
}
