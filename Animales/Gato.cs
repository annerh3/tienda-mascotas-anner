﻿namespace TiendaDeMascotas.Animales
{
    public class Gato : Animal
    {
        public string Color { get; set; }
        public Gato(string nombre, int edad, string color, string cuidador, string numeroTelefonoCuidador)
            : base(nombre, edad, cuidador, numeroTelefonoCuidador)
        {
            Color = color;
        }
        public override void Estado()
        {
            Console.WriteLine($"{Nombre} está durmiendo.");
        }
    }
}

