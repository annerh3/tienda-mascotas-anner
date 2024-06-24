namespace TiendaDeMascotas.Animales
{
    public class Hamster : Animal
    {
        public string Tipo { get; set; }
        public Hamster(string nombre, int edad, string tipo, string cuidador, string numeroTelefonoCuidador)
            : base(nombre, edad, cuidador, numeroTelefonoCuidador)
        {
            Tipo = tipo;
        }
        public override void Estado()
        {
            Console.WriteLine($"{Nombre} está corriendo en su rueda..");
        }
    }
}
