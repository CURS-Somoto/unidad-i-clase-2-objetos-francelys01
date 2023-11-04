
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_Combate
{
    public class Guerrero
    {
        public string Nombre
        {
            get;
            set;
        }
        public int Vida
        {
            get;
            set;
        }
        public int NivelAtaque
        {
            get;
            set;
        }
        
        public Guerrero(string Nom, int cant)
        {
           this.Nombre = Nom;
            Vida = 10;
            NivelAtaque = cant;
        }
    
        public int Ataque(int vida)
        {
            vida.RecibeAtaque();
           
    }
        }
        public void RecibeAtaque();
    {
        Vida -= 1;
        return Vida;
    }
public class Enfrentamiento
{
    public string Ganador { get; set; }
    public Guerrero Guerrero1 { get; set; }
    public Guerrero Guerrero2 { get; set; }

    public Enfrentamiento(Guerrero guerr1, Guerrero guerr2)
    {
        this.Guerrero1 = guerr1;
        this.Guerrero2 = guerr2;
    }
    public void iniciar()
    {
       Console.WriteLine("Inicia el combate");
       Console.WriteLine("Inicia Guerrero1");
        Guerrero1.Ataque();
        Guerrero2.Vida -= 1;
        Console.WriteLine("Inicia Guerreo2");
        Guerrero2.Ataque();
        Guerrero1.Vida -= 1;
        Console.WriteLine(Guerrero1.Vida);
        Console.WriteLine(Guerrero2.Vida);

       
}
   class Program
    {
        static void Main(string[] args)
        {
            Guerrero guerrero1 = new Guerrero("Peter", 10);
            Guerrero guerrero2 = new Guerrero("Maritza",10);

            Enfrentamiento competencia = new Enfrentamiento(guerr1, guerr2);
            Enfrentamiento.iniciar();
          
        
    }
}
}
}
