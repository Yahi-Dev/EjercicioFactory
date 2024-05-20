using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class Cuadrado : IFigura
    {
        public void Fabfigura()
        {
            Console.WriteLine("Su figura es un Cuadrado");
            Console.WriteLine(@" _______
|       |
|       |
|       |  _
|_______| |_|");
        }
    }
}
