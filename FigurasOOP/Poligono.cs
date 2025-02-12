using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal abstract class Poligono : Forma
    {
        private int numLados;

        public int NumLados
        {
            set { numLados = value; }
            get { return numLados; }
        }

        protected Poligono(int num) 
        { 
            this.numLados = num;
        }
    }
}
