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
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                continue;
            }

        }
    }
}