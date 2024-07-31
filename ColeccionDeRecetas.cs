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


    }
}
