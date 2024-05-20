using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class FiguraSeis : IFigura
    {
        public void Fabfigura()
        {
            Console.WriteLine("Su figura es un Hexagono");
            Console.WriteLine(@"          ____
         /    \
    ____/      \____
   /    \      /    \
  /      \____/      \
  \      /    \      /
   \____/      \____/
   /    \      /    \
  /      \____/      \
  \      /    \      /
   \____/      \____/
        \      /
         \____/");
        }
    }
}
