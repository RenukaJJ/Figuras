using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FigurasOOP
{
    internal class Elipse : Forma
    {
        private int largeRadius;
        private int smallRadius;

        public int LargeRadius
        {
            get { return largeRadius; }  
            set { largeRadius = value; }
        }

        public int SmallRadius
        {
            get { return smallRadius; }  
            set { smallRadius = value; }
        }

        public Elipse(int lRadius, int sRadius)
        {
            this.LargeRadius = lRadius;
            this.SmallRadius = sRadius;
        }

        public override double Area()
        {
            return Math.PI * largeRadius * smallRadius;
        }

        public override string ToString()
        {
            return $"Elipse de radio {largeRadius} y radio {smallRadius}. Area {this.Area()}";
        }
    }
}
