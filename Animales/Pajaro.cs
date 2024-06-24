using System;

namespace TiendaDeMascotas.Animales
{
    public class Pajaro : Animal
    {
        public string Especie { get; set; }
        public Pajaro(string nombre, int edad, string especie, string cuidador, string numeroTelefonoCuidador)
            : base(nombre, edad, cuidador, numeroTelefonoCuidador)
        {
            Especie = especie;
        }
        public override void Estado()
        {
            Console.WriteLine($"{Nombre} está comiendo.");
        }
    }
}
