using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Rectangulo : Poligono
    {
        private int altura;
        private int ancho;

        public int Altura
            { get { return altura; } set { altura = value; } }

        public int Ancho
            { get { return ancho; } set { ancho = value; } }

        public Rectangulo(int alt, int anch) : base(4)
        { 
            this.altura = alt;
            this.ancho = anch;
        }

        public override double Area()
        {
            return (double)altura * (double)ancho;
        }

        public override string ToString()
        {
            return $"Rectangulo de altura {altura} y anchura {ancho} unidades. Area {this.Area()}";
        }
    }
}
