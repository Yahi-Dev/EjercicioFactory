using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioUno
{
    class AnimalDesconocido : IAnimal
    {
        public void especie()
        {
            Console.WriteLine("Este animal es desconocido");
        }
    }
}
