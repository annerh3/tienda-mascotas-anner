    public class Menu
    {
    private Tienda tienda = new Tienda();
   
    public void MostrarMenu()
        {
            int opcion;
            do
            {   Console.Clear();
                Console.WriteLine("*-*-*-*- Tienda De Mascotas -*-*-*-*");
                Console.WriteLine("1. Agregar Mascota\n2. Listar Mascotas\n3. Ver Detalles de una Mascota\n4. Salir de la tienda.\nSeleccione una opción: ");
                
                opcion = int.Parse(Console.ReadLine());
        
                switch (opcion)
                {
                    case 1:
                    Console.Clear();
                        tienda.AgregarMascota();
                        break;
                    case 2:
                        tienda.ListarMascotas();
                        break;
                    case 3:
                        tienda.VerEstadoMascota();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar la Tienda de Mascotas. Bye :)");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\n--------------------------\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 4);
        }
    }