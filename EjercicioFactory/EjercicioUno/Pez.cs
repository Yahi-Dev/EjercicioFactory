using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioUno
{
    class Pez : IAnimal
    {
        public void especie()
        {
            Console.WriteLine("Su animal es un tipo de Pez");
            Console.WriteLine(@"      /`·.¸
     /¸...¸`:·
 ¸.·´  ¸   `·.¸.·´)
: © ):´;      ¸  {
 `·.¸ `·  ¸.·´\`·¸)
     `\\´´\¸.·´");
        }
    }
}
