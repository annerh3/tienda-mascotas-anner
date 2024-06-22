using System;

namespace TiendaDeMascotas.Animales
{
    public class Perro : Animal
    {
        public string Raza { get; set; }

        public Perro(string nombre, int edad, string raza, string cuidador, string numeroTelefonoCuidador)
            : base(nombre, edad, cuidador, numeroTelefonoCuidador)
        {
            Raza = raza;
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} está ladrando.");
        }
    }
}

