using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Cuadrado : Rectangulo
    {
        private int largo;

        public int Largo {  get { return largo; } set { value = largo; } }

        public Cuadrado(int l) : base(l, l)
        {
            this.largo = l;
        }

        public override string ToString()
        {
            return $"Cuadrado de lados de {largo} unidades. Area {this.Area()}. Perimetro {this.Perimetro()}.";
        }

        
    }
}
