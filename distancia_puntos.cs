using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia_de_puntos
{
    public class Punto
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        // Constructor para el plano bidimensional
        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Constructor para el plano tridimensional
        public Punto(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Método para medir la distancia en el plano bidimensional
        public double MedirDistancia(Punto destino)
        {
            double distancia = (double)Math.Sqrt(Math.Pow((double)(destino.x - this.x), 2) + Math.Pow((double)(destino.y - this.y), 2));
            return distancia;
        }

        // Método para medir la distancia en el espacio tridimensional
        public double MedirDistancia3dim(Punto destino)
        {
            double distancia = (double)Math.Sqrt(Math.Pow((double)(destino.x - this.x), 2) + Math.Pow((double)(destino.y - this.y), 2) + Math.Pow((double)(destino.z - this.z), 2));
            return distancia;
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
           // Puntos en el plano bidimensional
        Punto puntoOrigen2dim = new Punto(14, 30);
        Punto puntoDestino2dim = new Punto(8, 15);

        double distancia2dim = puntoOrigen2dim.MedirDistancia(puntoDestino2dim);
        Console.WriteLine("La distancia entre los puntos en 2 dimensiones es: " +distancia2dim);

        // Puntos en el espacio tridimensional
        Punto puntoOrigen3dim = new Punto(4, 5, 6);
        Punto puntoDestino3dim = new Punto(8, 9, 10);

        double distancia3dim = puntoOrigen3dim.MedirDistancia3dim(puntoDestino3dim);
        Console.WriteLine("La distancia entre los puntos en 3 dimensiones es: " +distancia3dim);
        Console.ReadKey();
        }
    }
}

