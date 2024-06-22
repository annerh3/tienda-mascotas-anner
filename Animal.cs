using System;

namespace TiendaDeMascotas
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cuidador { get; set; }
        private string NumeroTelefonoCuidador { get; set; }

        public Animal(string nombre, int edad, string cuidador, string numeroTelefonoCuidador)
        {
            Nombre = nombre;
            Edad = edad;
            Cuidador = cuidador;
            NumeroTelefonoCuidador = numeroTelefonoCuidador;
        }

        public abstract void HacerSonido();
        //public void Comer()
        //{
        //    Console.WriteLine($"{Nombre} está comiendo.");
        //}

        public string ObtenerNumeroTelefonoCuidador()
        {
            return NumeroTelefonoCuidador;
        }
    }
}

