using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioUno
{
    class Fabrica
    {
        public static IAnimal GetAnimal (string name)
        {
            if (name == "aire")
            {
                return new Ave();
            }
            if (name == "mar")
            {
                return new Pez();
            }
            if (name == "tierra")
            {
                return new Cuadrupedo();
            }
            else
            {
                return new AnimalDesconocido();
            }
        }

    }
}
