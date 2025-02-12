using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Triangulo : Poligono
    {
        private int ladoA;
        private int ladoB;
        private int ladoC;

        public int LadoA
            { get { return ladoA; } set { ladoA = value; } }

        public int LadoB
            { get { return ladoB; } set { ladoB = value; } }

        public int LadoC    
            { get { return ladoC; } set { ladoC = value; } }

        public Triangulo(int lA, int lB, int lC): base(3)
        {
            this.ladoA = lA;
            this.ladoB = lB;
            this.ladoC = lC;
        }

        public override double Area()
        {
            double s = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
        }

        public override double Perimetro()
        {
            return (double)(ladoA + ladoB + ladoC);
        }

        public override string ToString()
        {
            return $"Triangulo de lados {ladoA}, {ladoB} y {ladoC} unidades. Area {this.Area()}. Perimetro {this.Perimetro()}.";
        }
    }
}
