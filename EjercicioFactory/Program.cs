using EjercicioFactory.EjercicioDos;
using EjercicioFactory.EjercicioUno;

namespace EjercicioFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int ejercicio = 0;

            Console.WriteLine("Cual de los dos proyectos quiere ejectutar");
            ejercicio = Convert.ToInt32(Console.ReadLine());

            switch(ejercicio)
            {
                //EJERCICIO UNO
                case 1:
                    Console.Write("Digite los lados de su figura: ");
                    int lados = int.Parse(Console.ReadLine());
                    IFigura figura = FabricaFigura.GetFigura(lados);
                    figura.Fabfigura();
                break;

                //EJERCICIO DOS
                case 2:
                    Console.Write("Digite el tipo de terreno del habitad de su animal: ");
                    string especie = Console.ReadLine();
                    IAnimal animal = Fabrica.GetAnimal(especie);
                    animal.especie();
                break;

                default:
                    Console.WriteLine("Esta opcion no esta registrada");
                    Main(args);
                    break;
            }

            Console.ReadKey();
            Main(args);
        }
    }
}