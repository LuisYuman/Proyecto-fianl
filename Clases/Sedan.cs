using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class Sedan : VehiculoBase  //herencia de vehiculo base
    {

        //propiedades agregadas
        public string Bodykit { get; set; }
        public string Aleron { get; set; } 
        public string nitrogeno { get; set; }

        //metodo agregado
        public void Arranque_rapido()
        {
            Console.WriteLine("Su automovil esta preparado para hacer un arranque rapido");
        }
    }
}
