using TiendaDeMascotas;
using TiendaDeMascotas.Animales;
public class Tienda
{
    private List<Animal> animales = new List<Animal>();

    public void AgregarMascota()
    {
        Console.WriteLine("\n*-*-*-*- Agregar Mascota -*-*-*-*");
        Console.WriteLine("1. Perro\n2. Gato\n3. Hamster\n4. Pajaro\n5. Pez\n6. Conejo\n\n0. Volver a Menú Principal\nSeleccione el tipo de mascota: ");
        int tipo = int.Parse(Console.ReadLine());
        if(tipo == 0) { return;}// para volver al menú princip

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Cuidador: ");
        string cuidador = Console.ReadLine();
        Console.Write("Número de teléfono del cuidador: ");
        string numeroTelefonoCuidador = Console.ReadLine();

        switch (tipo)
        {
            case 1:
                Console.Write("Raza: ");
                string razaPerro = Console.ReadLine();
                animales.Add(new Perro(nombre, edad, razaPerro, cuidador, numeroTelefonoCuidador));
                break;
            case 2:
                Console.Write("Color: ");
                string colorGato = Console.ReadLine();
                animales.Add(new Gato(nombre, edad, colorGato, cuidador, numeroTelefonoCuidador));
                break;
            case 3:
                Console.Write("Tipo: ");
                string tipoHamster = Console.ReadLine();
                animales.Add(new Hamster(nombre, edad, tipoHamster, cuidador, numeroTelefonoCuidador));
                break;
            case 4:
                Console.Write("Especie: ");
                string especiePajaro = Console.ReadLine();
                animales.Add(new Pajaro(nombre, edad, especiePajaro, cuidador, numeroTelefonoCuidador));
                break;
            case 5:
                Console.Write("Tipo: ");
                string tipoPez = Console.ReadLine();
                animales.Add(new Pez(nombre, edad, tipoPez, cuidador, numeroTelefonoCuidador));
                break;
            case 6:
                Console.Write("Raza: ");
                string razaConejo = Console.ReadLine();
                animales.Add(new Conejo(nombre, edad, razaConejo, cuidador, numeroTelefonoCuidador));
                break;
            
            default:
                Console.WriteLine("Tipo de mascota no válido.");
                break;
        }

        Console.WriteLine("\nMascota agregada exitosamente!");
    }

    public void ListarMascotas()
    {
        Console.WriteLine("\n*-*-*-*- Lista de Mascotas -*-*-*-*");

        Console.WriteLine("Nombre       Edad           Cuidador");

        foreach (var animal in animales)
        {
            Console.WriteLine($"{animal.Nombre,-12} {animal.Edad}{" años",-10}    {animal.Cuidador}");
        }
    }

    public void VerEstadoMascota()
    {
        Console.WriteLine("\n*-*-*-*- Ver Detalles de una Mascota -*-*-*-*");
        Console.Write("\nNombre de la mascota a buscar: ");
        string nombre = Console.ReadLine();
        if (nombre is "") { return; } // volver a menu princip.
        var animal = animales.Find(a => a.Nombre.ToLower() == nombre.ToLower());
        
        Console.WriteLine("\n---------------\n");
        if (animal != null)
        {
            Console.WriteLine($@"Nombre: {animal.Nombre}
                                Edad: {animal.Edad}
                                Cuidador: {animal.Cuidador}
                                Número de teléfono del cuidador: {animal.ObtenerNumeroTelefonoCuidador()}");
            animal.Estado(); // polimorfismo
        }
        else
        {
            Console.WriteLine("Mascota no encontrada :(");
        }
    }
}