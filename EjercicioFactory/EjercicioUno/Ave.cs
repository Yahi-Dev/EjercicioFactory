using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioUno
{
    class Ave : IAnimal
    {
        public void especie()
        {
            Console.WriteLine("Su animal es un tipo Ave");
            Console.WriteLine(@"   \\
   (o>
\\_//)
 \_/_)
  _|_");
        }
    }
}
