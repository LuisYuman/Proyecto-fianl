﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class PickUp : VehiculoBase
    {
        public string DeTrabajo { get; set; }
        public string suspension { get; set; }
        public string llantasdeenduro { get; set; }

        public void Cargar()
        {
            Console.WriteLine("Cargando la pickup");
        }
    }
}