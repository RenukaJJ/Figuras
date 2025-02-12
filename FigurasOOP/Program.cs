using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasOOP
{
    internal class Program
    {
        static List<Forma> ListFormas = new List<Forma>();

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine(@"La opcion del menu
1. Ver lista de figuras
2. Crear Figura
3. Salir");
            while (true)
            {
                int opt = ConvertStringInt("Selecciona opcion del menu ");

                switch (opt)
                {
                    case 1:
                        MostrarLista();
                        break;
                    case 2:
                        CrearFigura();
                        break;
                    
                }

            }
        }

        public static void MostrarLista()
        {
            foreach (Forma forma in ListFormas) 
                Console.WriteLine(forma.ToString());
        }

        public static void CrearFigura()
        {
            Console.WriteLine(@"Figuras:
1. Circulo
2. Elipse
3. Triangulo
4. Cuadrado
5. Rectangulo");

            int opt = ConvertStringInt("Figura a crear: ");

            switch (opt)
            {
                case 1:
                    ListFormas.Add(new Circulo(ConvertStringInt("Radio del circulo: ")));
                    break;
                case 2:
                    ListFormas.Add(new Elipse(ConvertStringInt("Radio1: "), ConvertStringInt("Radio 2: ")));
                    break;
                case 3:
                    ListFormas.Add(new Triangulo(ConvertStringInt("Alto: "), ConvertStringInt("Ancho: "), ConvertStringInt("Angulo: ")));
                    break;
                case 4:
                    ListFormas.Add(new Cuadrado(ConvertStringInt("Lado: ")));
                    break;
                case 5:
                    ListFormas.Add(new Rectangulo(ConvertStringInt("Alto: "), ConvertStringInt("Ancho: ")));
                    break;
                case 6:
                    break;
                default:
                    break;
            }
        }

        static int ConvertStringInt(string pregunta)
        {
            int number;
            while (true)
            {
                Console.Write(pregunta);
                if (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Convertion failed. Introduce un numero valido.");
                else
                    return number;
            }
        }
    }
}
