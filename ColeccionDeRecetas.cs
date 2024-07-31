using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuReceta
{
    public class ColeccionDeRecetas
    {
        private List<Receta> recetas;

        public ColeccionDeRecetas()
        {
            recetas = new List<Receta>();
        }

        public void AgregarReceta(Receta receta)
        {
            recetas.Add(receta);
            Console.WriteLine("Receta agregada.");
        }

        public void BuscarRecetaPorNombre(string nombre)
        {
            foreach (var receta in recetas)
            {
                if (receta.Nombre.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine(receta);
                    return;
                }
            }
            Console.WriteLine("Receta no encontrada.");
        }

        public void MostrarTodasLasRecetas()
        {
            if (recetas.Count == 0)
            {
                Console.WriteLine("No hay recetas en la colección.");
            }
            else
            {
                foreach (var receta in recetas)
                {
                    Console.WriteLine(receta);
                    Console.WriteLine("------------------------------");
                }
            }
        }


    }
}
