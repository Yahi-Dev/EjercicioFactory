using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioDos
{
    class FiguraTres : IFigura
    {
        public void Fabfigura()
        {
            Console.WriteLine("su figura es un Triangulo");
            Console.WriteLine(@"/\   
              /__\ 
             /\  /\    
            /__\/__\
           /\      /\   
          /__\    /__\ 
         /\  /\  /\  /\ 
        /__\/__\/__\/__\
       /\              /\ 
      /__\            /__\ 
     /\  /\          /\  /\
    /__\/__\        /__\/__\
   /\      /\      /\      /\  
  /__\    /__\    /__\    /__\ 
 /\  /\  /\  /\  /\  /\  /\  /\
/__\/__\/__\/__\/__\/__\/__\/__\  ");
        }
    }
}
