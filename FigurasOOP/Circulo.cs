using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Circulo : Elipse
    {
        private int radius;

        public int Radius
        { 
            get { return radius; } 
            set { radius = value; } 
        }

        public Circulo(int radius) : base(radius, radius)
        {
            this.Radius = radius;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circulo de radio {radius} unidades. Area {this.Area()}. Perimetro {this.Perimetro()}.";
        }
    }
}
