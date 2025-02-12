using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Triangulo : Poligono
    {
        private int alto;
        private int ancho;
        private int angBeta;

        public int Alto
            { get { return alto; } set { alto = value; } }

        public int Ancho
            { get { return ancho; } set { ancho = value; } }

        public int AngBeta    
            { get { return angBeta; } set { angBeta = value; } }

        public Triangulo(int alt, int anch, int ang): base(3)
        {
            this.alto = alt;
            this.ancho = anch;
            this.angBeta = ang;
        }

        public override double Area()
        {
            return ((double)this.alto * (double)this.ancho) / 2;
        }

        public override string ToString()
        {
            return $"Triangulo de altura {alto}, anchura {ancho} unidades y angulo beta {angBeta} grados. Area {this.Area()}";
        }
    }
}
