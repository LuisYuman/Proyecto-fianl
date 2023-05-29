using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class SUV : VehiculoBase
    {
        public string respiradero { get; set; }
        public string winche { get; set; }
        public string repuestos { get; set; }

        public void ActivarTraccion4x4()
        {
            Console.WriteLine("Activando tracción 4x4 en la SUV");
        }
    }
}
