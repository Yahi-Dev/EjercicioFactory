using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class FiguraCinco : IFigura
    {
        public void Fabfigura()
        {
            Console.WriteLine("su figura es un Pentagono");
            Console.WriteLine(@"  __
   __/  \__
  /  \__/  \
  \__/  \__/
  /  \__/  \
  \__/  \__/
     \__/");
        }
    }
}
