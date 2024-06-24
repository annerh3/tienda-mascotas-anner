namespace TiendaDeMascotas.Animales
{
    public class Conejo : Animal
    {
        public string Raza { get; set; }
        public Conejo(string nombre, int edad, string raza, string cuidador, string numeroTelefonoCuidador) : base(nombre, edad, cuidador, numeroTelefonoCuidador)
        {
            Raza = raza;
        }
        public override void Estado()
        {
            Console.WriteLine($"{Nombre} está saltando.");
        }
    }
}
