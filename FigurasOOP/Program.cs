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
        static Diagrama Diagrama = new Diagrama();

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine(@"La opcion del menu
1. Ver lista de figuras en diagrama
2. Crear Figura en diagrama
3. Sumatoria de area y perimetro
4. Salir");
            while (true)
            {
                int opt = ConvertStringInt("Selecciona opcion del menu ");

                switch (opt)
                {
                    case 1:
                        Console.WriteLine(Diagrama.MostrarDiagrama());
                        break;
                    case 2:
                        CrearFigura();
                        break;
                    case 3:
                        Console.WriteLine($"Total area: {Diagrama.SumaArea()}. Total Perimetro: {Diagrama.SumaPerimetro()}.");
                        break;
                    default:
                        break;
                }

            }
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
                    Diagrama.AddForma(new Circulo(ConvertStringInt("Radio del circulo: ")));
                    break;
                case 2:
                    Diagrama.AddForma(new Elipse(ConvertStringInt("Radio 1: "), ConvertStringInt("Radio 2: ")));
                    break;
                case 3:
                    Diagrama.AddForma(new Triangulo(ConvertStringInt("Lado 1: "), ConvertStringInt("Lado 2: "), ConvertStringInt("Lado 3: ")));
                    break;
                case 4:
                    Diagrama.AddForma(new Cuadrado(ConvertStringInt("Lado: ")));
                    break;
                case 5:
                    Diagrama.AddForma(new Rectangulo(ConvertStringInt("Alto: "), ConvertStringInt("Ancho: ")));
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
