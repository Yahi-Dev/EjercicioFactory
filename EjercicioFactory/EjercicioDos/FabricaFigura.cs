using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class FabricaFigura
    {
        public static IFigura GetFigura (int lados)
        {
            if (lados == 0)
            {
                return Figura0.GetFigura0 ();
            }
            if (lados == 3)
            {
                return new FiguraTres();
            }

            if (lados == 4)
            {
                return new Cuadrado ();
            }
            if (lados == 5)
            {
                return new FiguraCinco ();
            }
            if (lados == 6)
            {
                return new FiguraSeis ();
            }
            else
            {
               return new FiguraDesconocida ();
            }
        }
    }
}
