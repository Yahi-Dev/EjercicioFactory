using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class FiguraDesconocida : IFigura
    {
        public void Fabfigura()
        {
            Console.WriteLine("NO LLEGANOS HASTA ESE PUNTO");
        }
    }
}
