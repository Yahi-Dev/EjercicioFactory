using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class Figura0 : IFigura
    {
        private static Figura0 instance;
        private Figura0() 
        {

        }

        public static Figura0 GetFigura0()
        {
            if (instance == null)
            {
                instance = new Figura0();
                return instance;
            }
            else
            {
                return instance;
            }
        }

       
        public void Fabfigura()
        {
            Console.WriteLine("Su figura es un Circulo");
            Console.WriteLine(@"     , - ~ ~ ~ - ,
     , '               ' ,
   ,                       ,
  ,                         ,
 ,                           ,
 ,                           ,
 ,                           ,
  ,                         ,
   ,                       ,
     ,                  , '
       ' - , _ _ _ ,  '
");
        }
    }
}
