﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactory.EjercicioUno
{
    class Cuadrupedo : IAnimal
    {
        public void especie()
        {
            Console.WriteLine("Su especie es un tipo Cuadrupedo");
        }
    }
}