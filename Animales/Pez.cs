using System;

namespace TiendaDeMascotas.Animales
{
    public class Pez : Animal
    {
        public string Tipo { get; set; }

        public Pez(string nombre, int edad, string tipo, string cuidador, string numeroTelefonoCuidador)
            : base(nombre, edad, cuidador, numeroTelefonoCuidador)
        {
            Tipo = tipo;
        }
        public override void Estado()
        {
            Console.WriteLine($"{Nombre} está nadando en la pesera, duh.");
        }
    }
}

