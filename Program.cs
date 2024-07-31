using MenuReceta;

class MenuRecetas
{
    static void Main(string[] args)
    {
        ColeccionDeRecetas coleccion = new ColeccionDeRecetas();

        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar Receta");
            Console.WriteLine("2. Buscar Receta por Nombre");
            Console.WriteLine("3. Mostrar Todas las Recetas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Esa opción no está dentro del menú");
                continue;
            }


            switch (opcion)
            {
                case 1:
                    AgregarReceta(coleccion);
                    break;
                case 2:
                    BuscarRecetaPorNombre(coleccion);
                    break;
                case 3:
                    coleccion.MostrarTodasLasRecetas();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Esa opción no está dentro del menú");
                    break;
            }
        }
    }

    static void AgregarReceta(ColeccionDeRecetas coleccion)
    {
        Console.Write("Ingrese el nombre de la receta: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese los ingredientes (separados por comas): ");
        string ingredientes = Console.ReadLine();

        Console.Write("Ingrese las instrucciones: ");
        string instrucciones = Console.ReadLine();

        Receta receta = new Receta(nombre, ingredientes, instrucciones);
        coleccion.AgregarReceta(receta);
    }

    static void BuscarRecetaPorNombre(ColeccionDeRecetas coleccion)
    {
        Console.Write("Ingrese la receta que desea buscar: ");
        string nombre = Console.ReadLine();
        coleccion.BuscarRecetaPorNombre(nombre);
    }

}