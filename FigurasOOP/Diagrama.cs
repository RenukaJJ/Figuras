using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Diagrama
    {
        private List<Forma> formaList;

        public List<Forma> FormaList { get { return formaList; } set { formaList = value; } }

        public Diagrama() 
        { 
            formaList = new List<Forma>();
        }

        public void AddForma(Forma f)
        {
            formaList.Add(f);
        }

        public string MostrarDiagrama()
        {
            string s = "";
            foreach (Forma forma in formaList)
                s += (forma.ToString()) + "\n";
            return s;
        }

        public double SumaArea()
        {
            double suma = 0;
            foreach (Forma forma in formaList)
                suma += forma.Area();
            return suma;
        }

        public double SumaPerimetro()
        {
            double suma = 0;
            foreach (Forma forma in FormaList)
                suma += forma.Perimetro();
            return suma;
        }
    }
}
